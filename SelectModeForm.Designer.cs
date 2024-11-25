namespace ProjectOOP
{
    partial class SelectModeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hostBtn = new Button();
            connectBtn = new Button();
            SuspendLayout();
            // 
            // hostBtn
            // 
            hostBtn.Location = new Point(90, 152);
            hostBtn.Name = "hostBtn";
            hostBtn.Size = new Size(253, 99);
            hostBtn.TabIndex = 0;
            hostBtn.Text = "Host";
            hostBtn.UseVisualStyleBackColor = true;
            hostBtn.Click += hostBtn_Click;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(381, 152);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(253, 99);
            connectBtn.TabIndex = 1;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // SelectModeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(connectBtn);
            Controls.Add(hostBtn);
            Name = "SelectModeForm";
            Text = "SelectModeForm";
            Load += SelectModeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button hostBtn;
        private Button connectBtn;
    }
}