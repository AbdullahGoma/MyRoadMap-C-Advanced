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
    public partial class Form1 : Form
    {
        FormMsg formMsg;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            //ColorDialog dlg = new ColorDialog();    
            //if(dlg.ShowDialog() == DialogResult.OK) lblMsg.ForeColor = dlg.Color;
            //if(fontDialog1.ShowDialog() == DialogResult.OK) lblMsg.Font = fontDialog1.Font;

            openFileDialog1.Filter = "PNG images | *.png | JPG images | *.jpeg | All | *.*";
            //SaveFileDialog

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //lblMsg.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            formMsg = new FormMsg(txtMsg.Text);
            formMsg.Closed += FormMsg_FormClosed;
            formMsg.InfoChanged += FormMsg_InfoChanged;
            //formMsg.Info = txtMsg.Text;
            formMsg.Show();
            //formMsg.ShowDialog();
            //txtMsg.Text = formMsg.Info;
        }

        private void FormMsg_InfoChanged(object sender, EventArgs e)
        {
            txtMsg.Text = formMsg.Info;
        }

        private void FormMsg_FormClosed(object sender, EventArgs e)
        {
            txtMsg.Text = formMsg.Info;
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            formMsg.Info = txtMsg.Text;
        }

    }
}
