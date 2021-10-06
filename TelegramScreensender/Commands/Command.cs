using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramRemote.Commands
{
    abstract class Command
    {
        private string answerText = "Неопознанная команда.";

        public string AnswerText { get => answerText; set => answerText = value; }

        public abstract void Execute();
    }
}
