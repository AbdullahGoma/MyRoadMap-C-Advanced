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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            colorMixer1.Color = Color.ForestGreen;
        }

        private void colorMixer1_ColorChanged(object sender, EventArgs e)
        {
            this.BackColor = colorMixer1.Color;
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            colorMixer1.Color = Color.AliceBlue;

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
        }

        private void colorMixer1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X = {e.X} \t Y = {e.Y}";
        }
    }
}
