using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //void Increment()
        //{
        //    for (int i = 0; i < 10000; i++)
        //    {
        //        txtResult.Text = i.ToString();
        //    }
        //}

        int Increment()
        {
            int counter = 0;
            //for (counter = 0; counter < 100000; counter++)
            //{
            //    for (int i = 0; i < 100000; i++)
            //    {

            //    }
            //}
            for (counter = 0; counter < 10; counter++)
            {
                Thread.Sleep(1000);
                Action action = () => txtResult.Text = counter.ToString();
                this.Invoke(action);
                //this.Invoke(() => txtResult.Text = counter.ToString()); // error here because there is delegate handle that without action
                /*txtResult.Text = counter.ToString();*/ // exception because only Marshall thread access that
            }
            return counter;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //int result = Increment(); // marshall thread
            int result = await Task.Run(() => Increment());
            txtResult.Text = result.ToString();
        }
    }
}
