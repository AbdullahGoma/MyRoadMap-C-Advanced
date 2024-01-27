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
    public partial class Form1 : Form
    {
        List<Continent> continents;
        List<Countries> countries;
        public Form1()
        {
            InitializeComponent();
            FillContinents();
            FillCountries();
            LoadContinents();
            LoadCountries();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void FillCountries()
        {
            countries = new List<Countries>
            {
                new Countries { Id = 1, Name = "Egypt" },
                new Countries { Id = 2, Name = "Libya" },
                new Countries { Id = 3, Name = "Sudan" }
            };
        }

        private void LoadCountries()
        {
            lstBxCountries.DataSource = countries;
            lstBxCountries.DisplayMember = "Name";
            lstBxCountries.ValueMember = "Id";
        }

        private void FillContinents()
        {

            continents = new List<Continent>
            {
                new Continent { Id = 1, Name = "Africa" },
                new Continent { Id = 2, Name = "Asia" },
                new Continent { Id = 3, Name = "Europe" }
            };
        }

        private void LoadContinents()
        {
            //cmbContinents.Items.Add("Africa");
            //cmbContinents.Items.Add("Asia");
            //cmbContinents.Items.Add("Europe");
            //string[] continents = new string[] { "Africa", "Asia", "Europe" };


            //cmbContinents.Items.AddRange(continents);
            //cmbContinents.SelectedIndex = 0;
            cmbContinents.DataSource = continents;
            cmbContinents.DisplayMember = "Name";
            cmbContinents.ValueMember = "Id";
            dataGridView1.DataSource = continents;

        }

        private void cmbContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbContinents.SelectedIndex == -1) return;
            //lblContinent.Text = cmbContinents.SelectedIndex.ToString();
            //lblContinent.Text = cmbContinents.SelectedItem as string;
            Continent continent = cmbContinents.SelectedItem as Continent;
            //lblContinent.Text = continent.Name;
            lblContinent.Text = continent.Id.ToString();
            //int id = (int)cmbContinents.SelectedValue;
            //lblContinent.Text = id.ToString();
        }

        private void btnContinents_Click(object sender, EventArgs e)
        {

            //cmbContinents.SelectedIndex = -1;
            //cmbContinents.Items.RemoveAt(0);
            continents.RemoveAt(0);
            cmbContinents.DataSource = null;
            //cmbContinents.DataSource = continents;
            LoadContinents();
            panel1.Visible = false;
        }

        private void lstBxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbContinents.SelectedIndex == -1) return;
            //lblCountries.Text = lstBxCountries.SelectedIndex.ToString();
            //lblBxCountries.Text = lstBxCountries.SelectedItem as string;
            Countries country = lstBxCountries.SelectedItem as Countries;
            //lstBxCountries.Text = countries.Name;
            lblCountries.Text = country.Id.ToString();
            //int id = (int)lstBxCountries.SelectedValue;
            //lstBxCountries.Text = id.ToString();
        }

        private void btnCountries_Click(object sender, EventArgs e)
        {
            //lstBxCountries.SelectedIndex = -1;
            //lstBxCountries.Items.RemoveAt(0);
            countries.RemoveAt(0);
            lstBxCountries.DataSource = null;
            //lstBxCountries.DataSource = countries;
            LoadCountries();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblContinent.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");
        }
    }
}
