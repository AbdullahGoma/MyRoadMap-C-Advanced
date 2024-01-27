using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewNine
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath Path = new GraphicsPath();
            Path.AddEllipse(10, 10, 100, 100);
            Region region = new Region(Path);

            this.Region = region;
        }
    }
}
