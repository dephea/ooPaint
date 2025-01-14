using System.Drawing;
using System.Windows.Forms;

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
            portInput = new TextBox();
            startButton = new Button();
            ipPortInput = new TextBox();
            SuspendLayout();
            // 
            // hostBtn
            // 
            hostBtn.Location = new Point(68, 39);
            hostBtn.Name = "hostBtn";
            hostBtn.Size = new Size(253, 99);
            hostBtn.TabIndex = 0;
            hostBtn.Text = "Host myself";
            hostBtn.UseVisualStyleBackColor = true;
            hostBtn.Click += hostBtn_Click;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(461, 39);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(253, 99);
            connectBtn.TabIndex = 1;
            connectBtn.Text = "Connect to another host";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // portInput
            // 
            portInput.Location = new Point(68, 187);
            portInput.Name = "portInput";
            portInput.PlaceholderText = "Port";
            portInput.Size = new Size(253, 31);
            portInput.TabIndex = 2;
            portInput.Visible = false;
            // 
            // startButton
            // 
            startButton.Location = new Point(263, 336);
            startButton.Name = "startButton";
            startButton.Size = new Size(263, 76);
            startButton.TabIndex = 3;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // ipPortInput
            // 
            ipPortInput.Location = new Point(461, 187);
            ipPortInput.Name = "ipPortInput";
            ipPortInput.PlaceholderText = "IP address + port";
            ipPortInput.Size = new Size(253, 31);
            ipPortInput.TabIndex = 4;
            ipPortInput.Visible = false;
            // 
            // SelectModeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ipPortInput);
            Controls.Add(startButton);
            Controls.Add(portInput);
            Controls.Add(connectBtn);
            Controls.Add(hostBtn);
            Name = "SelectModeForm";
            Text = "SelectModeForm";
            Load += SelectModeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hostBtn;
        private Button connectBtn;
        private TextBox portInput;
        private Button startButton;
        private TextBox ipPortInput;
    }
}