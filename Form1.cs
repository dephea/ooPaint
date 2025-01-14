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
        private Canvas myCanvas;
        private Tool tool;
        private Pencil pencil;
        private Eraser eraser;
        private Server server;
        private Client client;


        bool paint = false;
        Point currentPoint, previousPoint;

        public Form1(int port)
        {
            InitializeComponent();

            myCanvas = new Canvas(pic.Width, pic.Height);
            pic.Image = myCanvas.bitmap;
            g = myCanvas.graphics;
            pencil = new Pencil(Color.Black, 5);
            eraser = new Eraser(5);
            tool = pencil;


            Utils.SetupButtonImage(cursor, cursor.Image);

           
            this.Text = "Host";
            server = new Server();
            server.StartServer(port);
            server.OnActionReceived += ReceiveAction;


        }

        public Form1(string address, int port)
        {
            InitializeComponent();

            myCanvas = new Canvas(pic.Width, pic.Height);
            pic.Image = myCanvas.bitmap;
            g = myCanvas.graphics;
            pencil = new Pencil(Color.Black, 5);
            eraser = new Eraser(5);
            tool = pencil;


            Utils.SetupButtonImage(cursor, cursor.Image);

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
            currentPoint = e.Location;
            previousPoint = e.Location;
            tool.Draw(g, currentPoint, currentPoint);

            if (!Utils.isHost)
            {
                client.SendAction(tool, currentPoint, currentPoint);
            } else
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
                tool.Draw(g, currentPoint, previousPoint);
                if (!Utils.isHost)
                {
                    client.SendAction(tool, currentPoint, previousPoint);
                } else
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
    }
}
