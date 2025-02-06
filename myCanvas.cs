using System.Drawing;


namespace ProjectOOP
{
    public class myCanvas
    {
        public Bitmap bitmap { get; private set; }
        public Graphics graphics { get; private set; }

        public myCanvas(int width, int height) {
            bitmap = new Bitmap(width, height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
        }

        public void Clear()
        {
            graphics.Clear(Color.White);
        }
    }
}
