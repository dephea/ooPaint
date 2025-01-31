using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP
{
    public partial class Form1 : Form
    {

        private Graphics g;
        private myCanvas myCanvas;
        private Tool tool, pencil, eraser, rectangle, circle;
        //private Pencil pencil;
        //private Eraser eraser;
        //private Rectangle rectangle;
        private Server server;
        private Client client;


        bool paint = false;
        bool isFigure = false;
        Point startPoint, currentPoint, previousPoint;

        public Form1(int port)
        {
            InitializeComponent();

            myCanvas = new myCanvas(pic.Width, pic.Height);
            pic.Image = myCanvas.bitmap;
            g = myCanvas.graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            pencil = new Pencil(Color.Black, 5);
            eraser = new Eraser(5);
            rectangle = new Rectangle(Color.Green, 5);
            circle = new Circle(Color.DarkBlue, 5);
            tool = pencil;

            //pic.SizeMode = PictureBoxSizeMode.StretchImage;
            //pic.Dock = DockStyle.Fill;

            Utils.SetupButtonImage(cursor, cursor.Image);
            Utils.SetupButtonImage(eraserBtn, eraserBtn.Image);
            Utils.SetupButtonImage(rect_btn, rect_btn.Image);
            Utils.SetupButtonImage(circle_btn, circle_btn.Image);

            this.SizeChanged += Window_SizeChanged;


            this.Text = "Host";
            server = new Server();
            server.StartServer(port);
            server.OnActionReceived += ReceiveAction;


        }

        private void Window_SizeChanged(object? sender, EventArgs e)
        {
            int newLeft = (this.ClientSize.Width - pic.Width) / 2;
            int newTop = (this.ClientSize.Height - pic.Height) / 2;

            pic.Left = newLeft;
            pic.Top = newTop;
        }

        public Form1(string address, int port)
        {
            InitializeComponent();

            myCanvas = new myCanvas(pic.Width, pic.Height);
            pic.Image = myCanvas.bitmap;
            g = myCanvas.graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            pencil = new Pencil(Color.Black, 5);
            eraser = new Eraser(5);
            rectangle = new Rectangle(Color.Green, 5);
            circle = new Circle(Color.DarkBlue, 5);
            tool = pencil;

            Utils.SetupButtonImage(cursor, cursor.Image);
            Utils.SetupButtonImage(eraserBtn, eraserBtn.Image);
            Utils.SetupButtonImage(rect_btn, rect_btn.Image);
            Utils.SetupButtonImage(circle_btn, circle_btn.Image);

            this.SizeChanged += Window_SizeChanged;

            this.Text = "Client";
            client = new Client();
            client.Connect(address, port);
            client.OnActionReceived += ReceiveAction;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cursor_Click(object sender, EventArgs e)
        {
            tool = pencil;
            trackBar.Value = (int)tool.width;
            currentToolLabel.Text = "Pencil";
            color.BackColor = pencil.color;
            Debug.WriteLine("You clicked on the pencil tool");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            ////
        }
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            startPoint = e.Location;
            currentPoint = e.Location;
            previousPoint = e.Location;

            if (tool is ProjectOOP.Rectangle || tool is ProjectOOP.Circle)
            {
                isFigure = true;
                Debug.WriteLine("isFigure = true");
            }
            else
            {
                tool.Draw(g, currentPoint, currentPoint);
            }

            if (!Utils.isHost)
            {
                client.SendAction(tool, currentPoint, previousPoint);
            }
            else
            {
                server.SendAction(tool, currentPoint, previousPoint);
            }


            pic.Refresh();
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                currentPoint = e.Location;
                if (!isFigure)
                {
                    tool.Draw(g, currentPoint, previousPoint);
                }
                if (!Utils.isHost)
                {
                    client.SendAction(tool, currentPoint, previousPoint);
                }
                else
                {
                    server.SendAction(tool, currentPoint, previousPoint);
                }
                previousPoint = currentPoint;
            }
            pic.Refresh();
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            if (isFigure)
            {
                isFigure = false;
                tool.Draw(g, startPoint, e.Location);
            }
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            tool = eraser;
            trackBar.Value = (int)tool.width;
            currentToolLabel.Text = "Eraser";
        }

        private void color_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;

                tool.SetColor(selectedColor);

                color.BackColor = selectedColor;
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            tool.SetWidth(trackBar.Value);
        }

        private void eraserBtn_MouseDown(object sender, MouseEventArgs e)
        {
        }

        // for asynchronous processing.
        // makes everything faster
        private async void ReceiveAction(RemoteAction action)
        {
            Debug.WriteLine("ReceiveAction proc");
            // do ProcessRemoteAction in the current (UI) thread
            await Task.Run(() => Invoke(new Action(() => ProcessRemoteAction(action))));
        }


        private void ProcessRemoteAction(RemoteAction action)
        {

            if (action == null) return;

            Tool tool;

            if (action.title == "Pencil")
            {
                tool = new Pencil(action.color, action.width);
            }
            else if (action.title == "Eraser")
            {
                tool = new Eraser(action.width);
            }
            else
            {
                Debug.WriteLine($"Received unknown tool: {action.title}");
                return;
            }



            tool.Draw(g, action.start, action.end);

            pic.Refresh();
        }

        private void currentToolLabel_Click(object sender, EventArgs e)
        {

        }

        private void rect_btn_Click(object sender, EventArgs e)
        {
            tool = rectangle;
            trackBar.Value = (int)tool.width;
            currentToolLabel.Text = "Rectangle";
            color.BackColor = rectangle.color;
            Debug.WriteLine("You clicked on the Rectangle tool");
        }

        private void circle_btn_Click(object sender, EventArgs e)
        {
            tool = circle;
            trackBar.Value = (int)tool.width;
            currentToolLabel.Text = "Circle";
            color.BackColor = circle.color;
            Debug.WriteLine("You clicked on the Circle tool");
        }
    }
}
