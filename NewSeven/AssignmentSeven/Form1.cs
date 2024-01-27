using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AssignmentSeven
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxValue.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBoxValue.Text = textBoxValue.Text.Remove(textBoxValue.Text.Length - 1);
            }
        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            double ButtonMeterToKilometer = Double.Parse(textBoxValue.Text) / 1000.0f;
            double ButtonMeterToMile = Double.Parse(textBoxValue.Text) / 1609.344f;
            double ButtonMileToMeter = Double.Parse(textBoxValue.Text) * 1609.344f;
            if (radioButtonKilometer.Checked) textBoxResult.Text = Convert.ToString(ButtonMeterToKilometer);
            else if (radioButtonMile.Checked) textBoxResult.Text = Convert.ToString(ButtonMeterToMile);
            else if (radioButtonMeter.Checked) textBoxResult.Text = Convert.ToString(ButtonMileToMeter);

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            textBoxValue.Text = "";
        }
    }
}
