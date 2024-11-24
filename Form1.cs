namespace ProjectOOP
{
    public partial class Form1 : Form
    {

        private Graphics g;
        private Canvas myCanvas;
        private Tool tool;
        private Pencil pencil;
        private Eraser eraser;


        bool paint = false;
        Point px, py;

        public Form1()
        {
            InitializeComponent();

            myCanvas = new Canvas(pic.Width, pic.Height);
            pic.Image = myCanvas.bitmap;
            g = myCanvas.graphics;
            pencil = new Pencil(Color.Black, 5);
            eraser = new Eraser(5);
            tool = pencil;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cursor_Click(object sender, EventArgs e)
        {

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
            px = e.Location;
            py = e.Location;
            tool.Draw(g, px, px);
            pic.Invalidate();
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                px = e.Location;
                tool.Draw(g, px, py);
                py = px;
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
        }
    }
}
