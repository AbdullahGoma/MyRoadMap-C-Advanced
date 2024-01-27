using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewNine
{
    public partial class FormMsg : Form
    {
        public event EventHandler InfoChanged;
        public string Info 
        { 
            get { return txtInfo.Text; }
            set { txtInfo.Text = value; }
        }
        public FormMsg(string msg)
        {
            InitializeComponent();
            txtInfo.Text = msg;
        }

        private void FormMsg_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
             if(MessageBox.Show("Do you want to close the  form?", "This is a caption",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
             {
                e.Cancel = true;
             }
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            if(InfoChanged != null) InfoChanged(this, new EventArgs());
        }
    }
}
