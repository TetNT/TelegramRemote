using System;
using System.Drawing;
using Telegram.Bot;
using Telegram.Bot.Types;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using Telegram.Bot.Types.InputFiles;

namespace TelegramRemote.Commands
{
    class ScreenshotCommand : Command
    {
        private string screenSavingPath;
        private readonly ITelegramBotClient botClient;
        private readonly ChatId chatId;

        private async void SendScreenshotFile()
        {
            var fileStream = new FileStream(screenSavingPath, FileMode.Open, FileAccess.Read, FileShare.Read);
            try
            {
                await botClient.SendPhotoAsync(chatId, photo: new InputOnlineFile(fileStream)).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                AnswerText = "Не удалось отправить скриншот. " + e.Message;
            }
            finally
            {
                fileStream.Close();
            }
        }

        public ScreenshotCommand(ITelegramBotClient botClient, ChatId chatId, string screenSavingPath)
        {
            if (!botClient.IsReceiving) 
                throw new InvalidOperationException("Bot must be active.");
            this.botClient = botClient;
            this.chatId = chatId;
            this.screenSavingPath = screenSavingPath;
            AnswerText = "Отправка скриншота...";
        }

        public string ScreenSavingPath { get => screenSavingPath; set => screenSavingPath = value; }

        public override void Execute()
        {
            Screenshot screenshot = new Screenshot(
                Screen.AllScreens[0].Bounds.Width,
                Screen.AllScreens[0].Bounds.Height);
            screenshot.Save(screenSavingPath);
            if (System.IO.File.Exists(screenSavingPath)) {
                SendScreenshotFile();
            }
        }

        

    }
}
