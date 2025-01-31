using System;
using System.Drawing;


namespace ProjectOOP
{
    internal class Rectangle : Tool
    {
        public Rectangle(Color color, float width) : base(color, width) { }

        public override void Draw(Graphics g, Point start, Point end)
        {
            if (start == end)
            {
                //Brush brush = new SolidBrush(this.color);
                //g.FillEllipse(brush, start.X - this.width / 2, start.Y - this.width / 2, width, width);
            }
            else
            {
                int x = Math.Min(start.X, end.X);
                int y = Math.Min(start.Y, end.Y);
                int width = Math.Abs(start.X - end.X);
                int height = Math.Abs(start.Y - end.Y);
                g.DrawRectangle(base.pen, x, y, width, height);
            }
        }
    }
}
