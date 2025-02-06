using Newtonsoft.Json;
using System.Drawing;

namespace ProjectOOP
{
    public class RemoteAction
    {
        public string title { get; set; }
        public Color color { get; set; }
        public float width { get; set; }
        public Point start { get; set; }
        public Point end { get; set; }


        public RemoteAction(Tool tool, Point start, Point end) {
            this.title = tool.GetType().Name;
            this.color = tool.color;
            this.width = tool.width;
            this.start = start;
            this.end = end;
        }

        [JsonConstructor]
        public RemoteAction(string title, Color color, float width, Point start, Point end)
        {

            this.title = title;
            this.color = color;
            this.width = width;
            this.start = start;
            this.end = end;
        }
    }
}
