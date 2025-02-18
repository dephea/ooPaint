using System.Drawing;
using System.Windows.Forms;

namespace ProjectOOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            Fill_btn = new Button();
            Exit_btn = new Button();
            circle_btn = new Button();
            rect_btn = new Button();
            currentToolLabel = new Label();
            trackBar = new TrackBar();
            eraserBtn = new Button();
            cursor = new Button();
            color = new Button();
            panel2 = new Panel();
            pic = new PictureBox();
            colorDialog = new ColorDialog();
            canvasPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            canvasPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(Fill_btn);
            panel1.Controls.Add(Exit_btn);
            panel1.Controls.Add(circle_btn);
            panel1.Controls.Add(rect_btn);
            panel1.Controls.Add(currentToolLabel);
            panel1.Controls.Add(trackBar);
            panel1.Controls.Add(eraserBtn);
            panel1.Controls.Add(cursor);
            panel1.Controls.Add(color);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1820, 110);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Fill_btn
            // 
            Fill_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            Fill_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            Fill_btn.FlatStyle = FlatStyle.Flat;
            Fill_btn.ForeColor = Color.White;
            Fill_btn.Image = (Image)resources.GetObject("Fill_btn.Image");
            Fill_btn.Location = new Point(547, 12);
            Fill_btn.Name = "Fill_btn";
            Fill_btn.Size = new Size(87, 87);
            Fill_btn.TabIndex = 5;
            Fill_btn.UseVisualStyleBackColor = true;
            Fill_btn.Click += Fill_btn_Click;
            // 
            // Exit_btn
            // 
            Exit_btn.BackColor = Color.RosyBrown;
            Exit_btn.Location = new Point(1666, 18);
            Exit_btn.Margin = new Padding(4, 5, 4, 5);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(109, 75);
            Exit_btn.TabIndex = 6;
            Exit_btn.Text = "Exit";
            Exit_btn.UseVisualStyleBackColor = false;
            Exit_btn.Click += button1_Click_1;
            // 
            // circle_btn
            // 
            circle_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            circle_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            circle_btn.FlatStyle = FlatStyle.Flat;
            circle_btn.ForeColor = Color.White;
            circle_btn.Image = (Image)resources.GetObject("circle_btn.Image");
            circle_btn.Location = new Point(433, 12);
            circle_btn.Name = "circle_btn";
            circle_btn.Size = new Size(87, 87);
            circle_btn.TabIndex = 4;
            circle_btn.UseVisualStyleBackColor = true;
            circle_btn.Click += circle_btn_Click;
            // 
            // rect_btn
            // 
            rect_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            rect_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            rect_btn.FlatStyle = FlatStyle.Flat;
            rect_btn.ForeColor = Color.White;
            rect_btn.Image = (Image)resources.GetObject("rect_btn.Image");
            rect_btn.Location = new Point(324, 12);
            rect_btn.Name = "rect_btn";
            rect_btn.Size = new Size(87, 87);
            rect_btn.TabIndex = 3;
            rect_btn.UseVisualStyleBackColor = true;
            rect_btn.Click += rect_btn_Click;
            // 
            // currentToolLabel
            // 
            currentToolLabel.AutoSize = true;
            currentToolLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            currentToolLabel.Location = new Point(756, 18);
            currentToolLabel.Name = "currentToolLabel";
            currentToolLabel.Size = new Size(126, 54);
            currentToolLabel.TabIndex = 5;
            currentToolLabel.Text = "Pencil";
            currentToolLabel.Click += currentToolLabel_Click;
            // 
            // trackBar
            // 
            trackBar.Location = new Point(917, 23);
            trackBar.Maximum = 20;
            trackBar.Minimum = 1;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(476, 69);
            trackBar.TabIndex = 4;
            trackBar.Value = 5;
            trackBar.Scroll += trackBar_Scroll;
            trackBar.ValueChanged += trackBar_ValueChanged;
            // 
            // eraserBtn
            // 
            eraserBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            eraserBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            eraserBtn.FlatStyle = FlatStyle.Flat;
            eraserBtn.ForeColor = Color.White;
            eraserBtn.Image = Properties.Resources.icons8_eraser_96;
            eraserBtn.Location = new Point(114, 12);
            eraserBtn.Name = "eraserBtn";
            eraserBtn.Size = new Size(87, 87);
            eraserBtn.TabIndex = 3;
            eraserBtn.UseVisualStyleBackColor = true;
            eraserBtn.Click += eraser_Click;
            eraserBtn.MouseDown += eraserBtn_MouseDown;
            // 
            // cursor
            // 
            cursor.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            cursor.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            cursor.FlatStyle = FlatStyle.Flat;
            cursor.ForeColor = Color.White;
            cursor.Image = Properties.Resources.icons8_pen_96;
            cursor.Location = new Point(217, 12);
            cursor.Name = "cursor";
            cursor.Size = new Size(87, 87);
            cursor.TabIndex = 2;
            cursor.UseVisualStyleBackColor = true;
            cursor.Click += cursor_Click;
            // 
            // color
            // 
            color.BackColor = Color.Black;
            color.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            color.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            color.FlatStyle = FlatStyle.Flat;
            color.ForeColor = Color.White;
            color.Location = new Point(11, 12);
            color.Name = "color";
            color.Size = new Size(87, 87);
            color.TabIndex = 1;
            color.UseVisualStyleBackColor = false;
            color.Click += color_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 1023);
            panel2.Name = "panel2";
            panel2.Size = new Size(1820, 27);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(1817, 942);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Click += pic_Click;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // canvasPanel
            // 
            canvasPanel.BackColor = SystemColors.ControlDarkDark;
            canvasPanel.Controls.Add(pic);
            canvasPanel.Dock = DockStyle.Fill;
            canvasPanel.Location = new Point(0, 110);
            canvasPanel.Name = "canvasPanel";
            canvasPanel.Size = new Size(1820, 913);
            canvasPanel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 1050);
            Controls.Add(canvasPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ooPaint";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            canvasPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button color;
        private PictureBox pic;
        private Button cursor;
        private Button eraserBtn;
        private ColorDialog colorDialog;
        private Panel canvasPanel;
        private TrackBar trackBar;
        private Label currentToolLabel;
        private Button rect_btn;
        private Button circle_btn;
        private Button Exit_btn;
        private Button Fill_btn;
    }
}
