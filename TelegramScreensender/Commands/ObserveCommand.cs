using System;
using System.Drawing;
using System.Windows.Forms;

namespace TelegramRemote.Commands
{
    class ObserveCommand : Command
    {
        private Color observingPixel;
        private int observingPixelPosX;
        private int observingPixelPosY;
        private Timer timer;

        public ObserveCommand(int observingPixelPosX, int observingPixelPosY)
        {
            this.observingPixelPosX = observingPixelPosX;
            this.observingPixelPosY = observingPixelPosY;
            observingPixel = GetScreenPixel(observingPixelPosX, observingPixelPosY);
            
            AnswerText = "Включено отслеживание изменения экрана";
        }

        public override void Execute()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(TimerEvent);
            timer.Interval = 2500;
            timer.Start();
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Tick");
            if (PixelChanged(GetScreenPixel(observingPixelPosX, observingPixelPosY)))
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        private bool PixelChanged(Color currentPixel)
        {
            return observingPixel != currentPixel;
        }

        private Color GetScreenPixel(int posX = 0, int posY = 0)
        {
            Bitmap bitmap = new Bitmap(1, 1);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(new Point(posX-1, posY-1), new Point(0, 0), new Size(1, 1));
            return bitmap.GetPixel(posX-1, posY-1);
            
        }
    }
}
