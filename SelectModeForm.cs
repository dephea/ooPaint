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
            this.DialogResult = DialogResult.OK;            
            this.Close();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            Utils.isHost = false;
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
