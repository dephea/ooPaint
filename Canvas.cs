using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    public class Canvas
    {
        public Bitmap bitmap { get; private set; }
        public Graphics graphics { get; private set; }

        public Canvas(int width, int height) {
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
