
using System.Drawing;


namespace TelegramRemote
{
    class Screenshot
    {
        private Bitmap bitmap;
        public Screenshot(int width, int height)
        {
            bitmap = new Bitmap(
                width,
                height,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
        }

        public void Save(string path)
        {
            bitmap.Save(path);
        }
    }
}
