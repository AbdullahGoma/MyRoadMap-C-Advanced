using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEight
{
    public partial class Form2 : Form
    {
        int Counter = 0;
        List<Rectangle> rectangles = new List<Rectangle>(); 
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            //label1.Text = (++Counter).ToString();
            Graphics g = e.Graphics;
            //g.DrawRectangle(Pens.Red, 10, 10, 100, 100);
            //g.FillRectangle(Brushes.Red, 10, 10, 100, 100);

            foreach (Rectangle rectangle in rectangles)
            {
                g.DrawRectangle(Pens.Red, rectangle);
            }

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Rectangle rectangle = new Rectangle((int)numericX.Value, (int)numericY.Value, (int)numericW.Value, (int)numericH.Value);
            g.DrawRectangle(Pens.Red, rectangle);
            rectangles.Add(rectangle);
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //g.DrawRectangle(Pens.Red, e.X, e.Y, 50, 50);
            if (e.X >= 100 && e.X <= 200 && e.Y >= 100 && e.Y <= 200) btnDraw.Enabled = !btnDraw.Enabled; /*btnDraw.Enabled = false;*/
            //else btnDraw.Enabled = true;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //g.FillRectangle(Brushes.Red, e.X, e.Y, 50, 50);
            if(e.X >= 100 && e.X <= 200 && e.Y >= 100 && e.Y <= 200) g.FillRectangle(Brushes.Red, 100, 100, 100, 100);
            else g.FillRectangle(Brushes.Blue, 100, 100, 100, 100);
        }
    }
}
