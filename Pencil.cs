using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    internal class Pencil : Tool
    {
        public Pencil(Color color, float width) : base(color, width) { }

        public override void Draw(Graphics g, Point start, Point end)
        {
            if (start == end)
            {
                Brush brush = new SolidBrush(this.color);
                g.FillEllipse(brush, start.X - this.width / 2, start.Y - this.width / 2, width, width);
            } else
            {
                g.DrawLine(base.pen, end, start);
            }
            
        }
    }
}
