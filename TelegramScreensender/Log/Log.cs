using System.Windows.Forms;

namespace TelegramRemote
{
    class Log : ListBox
    {
        public void AddSystemMessage(SystemLogMessage systemLogMessage)
        {
            Items.Add(systemLogMessage);
        }
    }
}
