using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ProjectOOP
{

    internal class BucketFill : Tool
    {
        public BucketFill(Color color) : base(color) { }

        public override void Draw(Graphics g, Point start, Point end, Bitmap bitmap)
        {
            
            Color targetColor = bitmap.GetPixel(start.X, start.Y);

            // if color is already targetColor, then do nothing
            if (targetColor.ToArgb() == this.color.ToArgb())
                return;

            
            FloodFill(bitmap, start.X, start.Y, targetColor, this.color);

            
            g.DrawImage(bitmap, 0, 0);
        }

        public override void Draw(Graphics g, Point start, Point end)
        {
            return;
        }

        private void FloodFill(Bitmap bitmap, int x, int y, Color targetColor, Color fillColor)
        {
            Queue<Point> pixels = new Queue<Point>();
            pixels.Enqueue(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point p = pixels.Dequeue();

                if (p.X < 0 || p.Y < 0 || p.X >= bitmap.Width || p.Y >= bitmap.Height)
                    continue;

                if (bitmap.GetPixel(p.X, p.Y) != targetColor)
                    continue;

                // fill the pixel with the new color
                bitmap.SetPixel(p.X, p.Y, fillColor);

                // add neighbouring pixels in the queue
                pixels.Enqueue(new Point(p.X + 1, p.Y));
                pixels.Enqueue(new Point(p.X - 1, p.Y));
                pixels.Enqueue(new Point(p.X, p.Y + 1));
                pixels.Enqueue(new Point(p.X, p.Y - 1));
            }
        }
    }
}
