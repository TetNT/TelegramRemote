using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramRemote.Commands
{
    class ToggleMediaCommand : Command
    {
        public override void Execute()
        {
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            defaultPlaybackDevice.ToggleMute();
            if (defaultPlaybackDevice.IsMuted) AnswerText = "Звук отключён.";
            else AnswerText = "Звук включён.";
        }
    }
}
