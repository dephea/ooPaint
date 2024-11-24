using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    public abstract class Tool
    {
        public Pen pen { get; private set; }
        public Color color {  get; private set; }
        public float width { get; private set; }

        public Tool(Color color, float width) {
            this.color = color;
            this.width = width;
            pen = new Pen(this.color, this.width);
        }

        public void SetColor(Color color) {
            this.color = color;
            pen.Color = this.color;
        }

        public abstract void Draw(Graphics g, Point start, Point end);
    }
}
