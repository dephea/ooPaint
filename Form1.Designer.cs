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
            panel1 = new Panel();
            currentToolLabel = new Label();
            trackBar = new TrackBar();
            eraserBtn = new Button();
            cursor = new Button();
            color = new Button();
            panel2 = new Panel();
            pic = new PictureBox();
            colorDialog = new ColorDialog();
            canvasPanel = new Panel();
            logs = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            canvasPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(currentToolLabel);
            panel1.Controls.Add(trackBar);
            panel1.Controls.Add(eraserBtn);
            panel1.Controls.Add(cursor);
            panel1.Controls.Add(color);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1385, 110);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // currentToolLabel
            // 
            currentToolLabel.AutoSize = true;
            currentToolLabel.Font = new Font("Segoe UI", 14F);
            currentToolLabel.Location = new Point(249, 15);
            currentToolLabel.Name = "currentToolLabel";
            currentToolLabel.Size = new Size(90, 38);
            currentToolLabel.TabIndex = 5;
            currentToolLabel.Text = "Pencil";
            // 
            // trackBar
            // 
            trackBar.Location = new Point(85, 80);
            trackBar.Maximum = 20;
            trackBar.Minimum = 1;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(219, 69);
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
            eraserBtn.Location = new Point(85, 12);
            eraserBtn.Name = "eraserBtn";
            eraserBtn.Size = new Size(58, 53);
            eraserBtn.TabIndex = 3;
            eraserBtn.Text = "Eraser";
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
            cursor.Image = Properties.Resources.pencil;
            cursor.Location = new Point(158, 12);
            cursor.Name = "cursor";
            cursor.Size = new Size(59, 53);
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
            color.Location = new Point(12, 12);
            color.Name = "color";
            color.Size = new Size(55, 53);
            color.TabIndex = 1;
            color.UseVisualStyleBackColor = false;
            color.Click += color_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 742);
            panel2.Name = "panel2";
            panel2.Size = new Size(1385, 27);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(1385, 632);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // canvasPanel
            // 
            canvasPanel.Controls.Add(logs);
            canvasPanel.Controls.Add(pic);
            canvasPanel.Dock = DockStyle.Fill;
            canvasPanel.Location = new Point(0, 110);
            canvasPanel.Name = "canvasPanel";
            canvasPanel.Size = new Size(1385, 632);
            canvasPanel.TabIndex = 3;
            // 
            // logs
            // 
            logs.BackColor = SystemColors.HotTrack;
            logs.Location = new Point(341, 549);
            logs.Multiline = true;
            logs.Name = "logs";
            logs.ScrollBars = ScrollBars.Vertical;
            logs.Size = new Size(627, 77);
            logs.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 769);
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
            canvasPanel.PerformLayout();
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
        private TextBox logs;
    }
}
