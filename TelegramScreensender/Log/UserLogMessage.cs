using System;
using Telegram.Bot.Types;

namespace TelegramRemote
{
    class UserLogMessage : LogMessage
    {
        private string chatId;
        private string author;
        private DateTime date;

        public string ChatId { get => chatId; }
        public string Author { get => author; }
        public DateTime Date { get => date; }
        /// <summary>
        /// Создаёт экземпляр сообщения от пользователя или бота.
        /// </summary>
        /// <param name="description">Описание темы сообщения.</param>
        /// <param name="text">Текст сообщения</param>
        /// <param name="chatId">Чат, из которого получают или в который отправляют сообщение.</param>
        /// <param name="messageAuthor">Автор сообщения.</param>
        public UserLogMessage(string description, string text, string chatId, string author)
        {
            this.description = description;
            this.text = text;
            this.chatId = chatId;
            this.author = author;
        }

        public UserLogMessage(string description, Message message)
        {
            this.description = description;
            chatId = message.Chat.Id.ToString();
            text = message.Text;
            author = message.From.FirstName + " " + message.From.LastName + "(" + message.From.Username + ")";
            date = message.Date;
        }

        public override string ToString()
        {
            return description + text;
        }
    }
}
