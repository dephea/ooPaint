using System.Drawing;

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

        public Tool(Color color) {
            this.color = color;
            pen = new Pen(this.color);
        }

        public void SetColor(Color color) {
            this.color = color;
            pen.Color = this.color;
        }

        public void SetWidth(float width)
        {
            this.width = width;
            pen.Width = this.width;
        }

        public abstract void Draw(Graphics g, Point start, Point end);

        // for bucketfill
        public abstract void Draw(Graphics g, Point start, Point end, Bitmap bitmap);
    }
}
