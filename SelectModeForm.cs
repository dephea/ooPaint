using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP
{
    public partial class SelectModeForm : Form
    {

        public SelectModeForm()
        {
            InitializeComponent();
        }

        private void SelectModeForm_Load(object sender, EventArgs e)
        {

        }

        private void hostBtn_Click(object sender, EventArgs e)
        {
            Utils.isHost = true;
            portInput.Visible = true;
            ipPortInput.Visible = false;
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            Utils.isHost = false;
            ipPortInput.Visible = true;
            portInput.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string address;
            int port;
            if (!string.IsNullOrEmpty(ipPortInput.Text))
            {
                try
                {
                    string[] parts = ipPortInput.Text.Split(':');
                    if (parts.Length != 2)
                    {
                        throw new FormatException("Format should be 'address:port'!");
                    }

                    address = parts[0];
                    port = int.Parse(parts[1]);

                    Form1 clientForm = new Form1(address, port);
                    MessageBox.Show($"Connected to another host: {address}:{port}");
                    this.Hide();
                    clientForm.ShowDialog();
                    this.Close();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (!string.IsNullOrEmpty(portInput.Text))
            {
                try
                {
                    port = int.Parse(portInput.Text);

                    // Application.Run(new Form1(port));
                    Form1 serverForm = new Form1(port);
                    MessageBox.Show($"Server started on port: {port}");
                    this.Hide(); 
                    serverForm.ShowDialog(); 
                    this.Close(); 

                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please input a port for hosting or address for connecting to another host.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
