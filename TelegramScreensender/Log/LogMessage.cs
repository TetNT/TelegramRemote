using System;
using Telegram.Bot.Args;

namespace TelegramRemote
{
    abstract class LogMessage
    {
        protected string text;
        protected string description;


        public override string ToString()
        {
            return description + text;
        }

        public string Text { get => text; }
        public string Description { get => description; }
    }
}
