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
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1274, 66);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // circle_btn
            // 
            circle_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            circle_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            circle_btn.FlatStyle = FlatStyle.Flat;
            circle_btn.ForeColor = Color.White;
            circle_btn.Image = (Image)resources.GetObject("circle_btn.Image");
            circle_btn.Location = new Point(303, 7);
            circle_btn.Margin = new Padding(2, 2, 2, 2);
            circle_btn.Name = "circle_btn";
            circle_btn.Size = new Size(61, 52);
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
            rect_btn.Location = new Point(230, 7);
            rect_btn.Margin = new Padding(2, 2, 2, 2);
            rect_btn.Name = "rect_btn";
            rect_btn.Size = new Size(61, 52);
            rect_btn.TabIndex = 3;
            rect_btn.UseVisualStyleBackColor = true;
            rect_btn.Click += rect_btn_Click;
            // 
            // currentToolLabel
            // 
            currentToolLabel.AutoSize = true;
            currentToolLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            currentToolLabel.Location = new Point(412, 12);
            currentToolLabel.Margin = new Padding(2, 0, 2, 0);
            currentToolLabel.Name = "currentToolLabel";
            currentToolLabel.Size = new Size(86, 37);
            currentToolLabel.TabIndex = 5;
            currentToolLabel.Text = "Pencil";
            currentToolLabel.Click += currentToolLabel_Click;
            // 
            // trackBar
            // 
            trackBar.Location = new Point(535, 7);
            trackBar.Margin = new Padding(2, 2, 2, 2);
            trackBar.Maximum = 20;
            trackBar.Minimum = 1;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(194, 45);
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
            eraserBtn.Location = new Point(80, 7);
            eraserBtn.Margin = new Padding(2, 2, 2, 2);
            eraserBtn.Name = "eraserBtn";
            eraserBtn.Size = new Size(61, 52);
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
            cursor.Location = new Point(152, 7);
            cursor.Margin = new Padding(2, 2, 2, 2);
            cursor.Name = "cursor";
            cursor.Size = new Size(61, 52);
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
            color.Location = new Point(8, 7);
            color.Margin = new Padding(2, 2, 2, 2);
            color.Name = "color";
            color.Size = new Size(61, 52);
            color.TabIndex = 1;
            color.UseVisualStyleBackColor = false;
            color.Click += color_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 635);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1274, 16);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Location = new Point(0, 0);
            pic.Margin = new Padding(2, 2, 2, 2);
            pic.Name = "pic";
            pic.Size = new Size(1272, 565);
            pic.TabIndex = 2;
            pic.TabStop = false;
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
            canvasPanel.Location = new Point(0, 66);
            canvasPanel.Margin = new Padding(2, 2, 2, 2);
            canvasPanel.Name = "canvasPanel";
            canvasPanel.Size = new Size(1274, 569);
            canvasPanel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 651);
            Controls.Add(canvasPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
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
    }
}
