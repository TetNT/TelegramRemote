using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramRemote
{
    class SystemLogMessage : LogMessage
    {

        /// <summary>
        /// Создаёт экземпляр системного сообщения для лога.
        /// </summary>
        /// <param name="text">Текст сообщения.</param>
        public SystemLogMessage(string text)
        {
            this.text = text;
        }

        public SystemLogMessage(string text, string description)
        {
            this.text = text;
            this.description = description;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
