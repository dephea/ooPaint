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
            hostBtn.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            hostBtn.Location = new Point(48, 23);
            hostBtn.Margin = new Padding(2);
            hostBtn.Name = "hostBtn";
            hostBtn.Size = new Size(282, 59);
            hostBtn.TabIndex = 0;
            hostBtn.Text = "Host myself";
            hostBtn.UseVisualStyleBackColor = true;
            hostBtn.Click += hostBtn_Click;
            // 
            // connectBtn
            // 
            connectBtn.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            connectBtn.Location = new Point(523, 23);
            connectBtn.Margin = new Padding(2);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(282, 59);
            connectBtn.TabIndex = 1;
            connectBtn.Text = "Connect to another host";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // portInput
            // 
            portInput.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            portInput.Location = new Point(48, 133);
            portInput.Margin = new Padding(2);
            portInput.Name = "portInput";
            portInput.PlaceholderText = "Port";
            portInput.Size = new Size(282, 38);
            portInput.TabIndex = 2;
            portInput.Visible = false;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(221, 307);
            startButton.Margin = new Padding(2);
            startButton.Name = "startButton";
            startButton.Size = new Size(416, 124);
            startButton.TabIndex = 3;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // ipPortInput
            // 
            ipPortInput.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            ipPortInput.Location = new Point(523, 133);
            ipPortInput.Margin = new Padding(2);
            ipPortInput.Name = "ipPortInput";
            ipPortInput.PlaceholderText = "IP address + port";
            ipPortInput.Size = new Size(282, 38);
            ipPortInput.TabIndex = 4;
            ipPortInput.Visible = false;
            // 
            // SelectModeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 478);
            Controls.Add(ipPortInput);
            Controls.Add(startButton);
            Controls.Add(portInput);
            Controls.Add(connectBtn);
            Controls.Add(hostBtn);
            Margin = new Padding(2);
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