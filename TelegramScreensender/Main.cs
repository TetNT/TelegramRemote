using System;
using System.Drawing;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Args;
using TelegramRemote.Commands;
using System.Runtime.InteropServices;

namespace TelegramRemote
{
    public partial class Main : Form
    {
        private static ITelegramBotClient botClient;
        private static string screenSavingPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\TGSS.png";
        private Color observingPixelColor;

        private enum ProcessDPIAwareness
        {
            ProcessDPIUnaware = 0,
            ProcessSystemDPIAware = 1,
            ProcessPerMonitorDPIAware = 2
        }

        [DllImport("shcore.dll")]
        private static extern int SetProcessDpiAwareness(ProcessDPIAwareness value);

        private static void SetDpiAwareness()
        {
            try
            {
                if (Environment.OSVersion.Version.Major >= 6)
                    SetProcessDpiAwareness(ProcessDPIAwareness.ProcessPerMonitorDPIAware);
            }
            catch (EntryPointNotFoundException)
            {
            }
        }

        public Main()
        {
            SetDpiAwareness();
            InitializeComponent();
        }


        private static MessageEventArgs receivedMessage;

        private void BotClient_OnMessage(object sender, MessageEventArgs e)
        {
            receivedMessage = e;
            var text = receivedMessage?.Message?.Text;
            if (text == null)
                return;
            var chat = e.Message.Chat;
            UserLogMessage log = new UserLogMessage("Получено сообщение от пользователя: ", e.Message);
            Invoke((Action)(() => logList.Items.Add(log)));
            ProcessMessage(text);
        }

        private void ProcessMessage(string userMessage)
        {
            try
            {
                Command command = GetCommand(userMessage);
                command.Execute();
                SendMessageAndLog(receivedMessage.Message.Chat, command.AnswerText);
            }
            catch
            {
                AddSystemMessageToLog("Не удалось распознать команду");
                throw;
            }
        }

        private void ProcessCommand(string command)
        {
            string answer;
            Telegram.Bot.Types.Chat chat = receivedMessage.Message.Chat;
            switch (command)
            {
                case "/observe":
                    answer = "Установка слежки за сменой окон";
                    observingPixelColor = getPixelFromThePosition(0, 0);
                    SendMessageAndLog(chat, answer);
                    pixelObserverTimer.Tag = chat;
                    pixelObserverTimer.Enabled = true;
                    pixelObserverTimer.Start();
                    break;
            }
            
        }

        /// <summary>
        /// Returns an instance of Command class depending on user's input.
        /// </summary>
        /// <param name="userMessage"></param>
        /// <returns></returns>
        private Command GetCommand(string userMessage)
        {
            var chatId = receivedMessage.Message.Chat;
            switch (userMessage)
            {
                case "/screenshot":
                    return new ScreenshotCommand(botClient, chatId, screenSavingPath);
                case "/observe":
                    return new ObserveCommand(1,1);
                case "/shutdown":
                    return new ShutdownCommand();
                case "/togglemute":
                    return new ToggleMediaCommand();
                case "/setvolume":

                default:
                    break;
            }
            if (userMessage.StartsWith("/setvolume"))
            {
                return new SetVolumeCommand(userMessage);
            }
            throw new Exception("Bad command request");
        }

       
        private void pixelObserverTimer_Tick(object sender, EventArgs e)
        {
            if (observingPixelColor.Name == "0") return;
            Color currentPixelColor = getPixelFromThePosition(0, 0);
            if (observingPixelColor != currentPixelColor)
            {
                var chat = (pixelObserverTimer.Tag as Telegram.Bot.Types.Chat);
                botClient.SendTextMessageAsync(chat.Id, "Экран изменился!");
                pixelObserverTimer.Stop();
            }
        }

        private Color getPixelFromThePosition(int posX, int posY)
        {
            Bitmap bitmap = new Bitmap(1, 1);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(new Point(posX, posY), new Point(0, 0), new Size(1, 1));
            return bitmap.GetPixel(0,0);
        }


        private async void SendMessageAndLog(Telegram.Bot.Types.ChatId chatId, string answer)
        {
            await botClient.SendTextMessageAsync(chatId, answer);
            UserLogMessage log = new UserLogMessage("Отправлен ответ: ", answer, chatId, "Бот");
            Invoke((Action)(() => logList.Items.Add(log)));
        }

        private void AddSystemMessageToLog(string message)
        {
            SystemLogMessage log = new SystemLogMessage(message);
            Invoke((Action)(()=> {
                logList.Items.Add(log);
                logList.SelectedIndex = logList.Items.Count - 1;
                logList.SelectedIndex = -1;
            } )); 
        }

        private void AddEnhancedSystemMessageToLog(string title, string description)
        {
            SystemLogMessage msg = new SystemLogMessage(title, description);
            logList.Items.Add(msg);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            AddEnhancedSystemMessageToLog(
                "Здесь отображается лог событий системы и телеграма. Нажмите для доп. информации...",
                "Здесь отображается полный текст сообщения или дополнительная информация.");
            AddSystemMessageToLog("Загрузка конфигурации...");
            string[] cfg = Configuration.Get();
            if (cfg[0] == "") AddSystemMessageToLog("Токен бота не обнаружен. Укажите его перед запуском.");
            if (cfg[1] == "") AddSystemMessageToLog("Папка для сохранения скриншотов не указана. Рекомендуется заполнить данное поле.");
            tbBotToken.Text = cfg[0];
            tbScreenSavingPath.Text = cfg[1];
            AddSystemMessageToLog("Загрузка конфигурации завершена.");

        }

        private void bSelectPath_Click(object sender, EventArgs e)
        {
            folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderDialog.Description = "Выбор папки для хранения скриншотов";
            var result = folderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbScreenSavingPath.Text = folderDialog.SelectedPath;
            }
            
        }

        private void bShowToken_Click(object sender, EventArgs e)
        {
            if ((string)bShowToken.Tag == "hidden")
            {
                tbBotToken.PasswordChar = '\0';
                bShowToken.Tag = "shown";
                bShowToken.Text = "Скрыть";
            }
            else
            {
                tbBotToken.PasswordChar = '•';
                bShowToken.Tag = "hidden";
                bShowToken.Text = "Показать";
            }
        }

        private void logList_Click(object sender, EventArgs e)
        {
            var message = logList.SelectedItem;
            if (message == null) return;
            if (!(message is SystemLogMessage))
            {
                UserLogMessage userMessage = message as UserLogMessage;
                lbMessageInformation.Text = "Чат: " + userMessage.ChatId + '\n' + "От: " + userMessage.Author + '\n' + "Время: " + userMessage.Date;
                tbFullTextMessage.Text = userMessage.Text;
            }
            else
            {
                SystemLogMessage systemMessage = message as SystemLogMessage;
                lbMessageInformation.Text = "Системное сообщение.";
                tbFullTextMessage.Text = systemMessage.Description;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти и прервать работу бота?", "Завершение работы", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                pixelObserverTimer.Dispose();
                Configuration.Save(tbBotToken.Text, tbScreenSavingPath.Text);
            }
        }

        private void bBotStart_Click(object sender, EventArgs e)
        {
            if (tbBotToken.Text == "")
            {
                AddSystemMessageToLog("Перед запуском необходимо указать API-ключ бота.");
                tbBotToken.Focus();
                return;
            }
            AddSystemMessageToLog("Инициализация...");
            try
            {
                botClient = new TelegramBotClient(tbBotToken.Text);
                var bot = botClient.GetMeAsync().Result;
                botClient.OnMessage += BotClient_OnMessage;
                botClient.StartReceiving();
                AddSystemMessageToLog("Бот включен и принимает сообщения.");
            }
            catch (ArgumentException)
            {
                AddSystemMessageToLog("При инициализации возникла ошибка: неправильный формат токена.");
            }
            catch (AggregateException)
            {
                AddSystemMessageToLog("При инициализации возникла ошибка: неавторизованный токен.");
            }
            
        }

        private void bBotStop_Click(object sender, EventArgs e)
        {
            botClient.StopReceiving();
            AddSystemMessageToLog("Бот остановлен.");
        }

    }
}
