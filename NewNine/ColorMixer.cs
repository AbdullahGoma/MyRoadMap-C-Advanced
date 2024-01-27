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
    public partial class ColorMixer : UserControl
    {
        public event EventHandler ColorChanged;
        public Color Color
        {
            get 
            { 
                return Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value); 
            }
            set
            {
                trackBarRed.Value = value.R;
                trackBarGreen.Value = value.G;
                trackBarBlue.Value = value.B;
            }
        }
        public ColorMixer()
        {
            InitializeComponent();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if(ColorChanged != null) ColorChanged(this, EventArgs.Empty);
        }

        private void trackBarBlue_ValueChanged(object sender, EventArgs e)
        {
            if (ColorChanged != null) ColorChanged(this, EventArgs.Empty);
        }
    }
}
