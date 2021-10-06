using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramRemote.Commands
{
    sealed class ShutdownCommand : Command
    {
        public override void Execute()
        {
            Process.Start("shutdown", "/s /f /t 0");
            AnswerText = "Выключение рабочей машины...";
        }
    }
}
