using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSeven
{
    // Form1 subscriber to Form
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.MouseMove += Form1_MouseMove;
            //this.Text = "Hello First";
            //this.BackColor = Color.FromArgb(200, 100, 100); //Color.GreenYellow;
            
            //Button button = new Button(); //Publisher
            //button.Location = new Point(100, 100);
            //button.Text = "OK";
            //button.Click += Button_Click;
            //this.Controls.Add(button); // ControlCollection
        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 100, 100);
            btnMsg.Visible = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X = {e.X} \t Y = {e.Y}";
            //this.BackColor = Color.FromArgb(e.X % 255, e.Y % 255, e.X % 255);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void RadioButtonColors_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked) textBoxMsg.ForeColor = Color.Red;
            else if(radioButtonGreen.Checked) textBoxMsg.ForeColor = Color.Green;
            else if (radioButtonYellow.Checked) textBoxMsg.ForeColor = Color.Yellow;
        }

        private void textBoxMsg_TextChanged(object sender, EventArgs e)
        {
            lblMsg.Text = textBoxMsg.Text;
        }
    }
}
