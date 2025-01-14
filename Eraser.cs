using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    internal class Eraser : Tool 
    {
        public Eraser(float width) : base(Color.White, width) {
            pen.Color = Color.White;
        }

        public override void Draw(Graphics g, Point start, Point end)
        {
            if (start == end)
            {
                Brush brush = new SolidBrush(this.color);
                g.FillEllipse(brush, start.X - this.width / 2, start.Y - this.width / 2, width, width);
            }
            else
            {
                g.DrawLine(base.pen, end, start);
            }
        }
    }
}
