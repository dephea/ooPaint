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
            cursor = new Button();
            color = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(cursor);
            panel1.Controls.Add(color);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 110);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // cursor
            // 
            cursor.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            cursor.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            cursor.FlatStyle = FlatStyle.Flat;
            cursor.ForeColor = Color.White;
            cursor.Location = new Point(180, 12);
            cursor.Name = "cursor";
            cursor.Size = new Size(114, 38);
            cursor.TabIndex = 2;
            cursor.Text = "Cursor";
            cursor.UseVisualStyleBackColor = true;
            cursor.Click += cursor_Click;
            // 
            // color
            // 
            color.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            color.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            color.FlatStyle = FlatStyle.Flat;
            color.ForeColor = Color.White;
            color.Location = new Point(60, 12);
            color.Name = "color";
            color.Size = new Size(114, 38);
            color.TabIndex = 1;
            color.Text = "Color";
            color.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(42, 39);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 467);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 27);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 110);
            pic.Name = "pic";
            pic.Size = new Size(778, 357);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 494);
            Controls.Add(pic);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button color;
        private Button button1;
        private PictureBox pic;
        private Button cursor;
    }
}
