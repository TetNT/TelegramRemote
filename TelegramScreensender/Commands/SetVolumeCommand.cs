using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Linq;

namespace TelegramRemote.Commands
{
    class SetVolumeCommand : Command
    {
        private char operand = '\0';
        private int volume = 0;
        private string[] commandParts;
        public SetVolumeCommand(string commandText)
        {
            ParsedCommand parsed = new ParsedCommand(commandText);
            commandParts = parsed.ParseCommandToStringList();
            if (parsed.DataIsValid())
            {
                SetOperand();
                SetVolume();
            }  
        }

        private void SetOperand()
        {
            if (commandParts.Length == 1)
            {
                operand = '\0';
            }
            string volumeParameter = commandParts[1];
            if (volumeParameter.Contains('+')) operand = '+';
            else if (volumeParameter.Contains('-')) operand = '-';
            else operand = '=';
        }

        private void SetVolume()
        {
            volume = Int32.Parse(commandParts[1].Trim('+','-','=',' '));
        }

        public override void Execute()
        {
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            switch (operand)
            {
                case '+':
                    defaultPlaybackDevice.Volume += volume;
                    AnswerText = $"{operand}{volume} к громкости. {defaultPlaybackDevice.Volume}/100";
                    break;
                case '-':
                    defaultPlaybackDevice.Volume -= volume;
                    AnswerText = $"{operand}{volume} к громкости. {defaultPlaybackDevice.Volume}/100";
                    break;
                case '=':
                    defaultPlaybackDevice.Volume = volume;
                    AnswerText = $"Громкость установлена на {volume}.";
                    break;
                default:
                    AnswerText = "Неправильные параметры команды.";
                    break;
            }

        }

        class ParsedCommand
        {
            private string command;
            public ParsedCommand(string commandStr)
            {
                if (commandStr.Length == 0) throw new ArgumentException("Command is empty.");
                command = commandStr;
            }
            public string[] ParseCommandToStringList()
            {
                return command.Split(' ');
            }
            
            public bool DataIsValid()
            {
                string[] splittedCommand = ParseCommandToStringList();
                if (splittedCommand.Length == 1) return false;
                return true;
            }
        }
    }
}
