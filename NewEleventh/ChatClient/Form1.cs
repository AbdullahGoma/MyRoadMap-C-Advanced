using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        StreamReader streamReader;
        StreamWriter streamWriter;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Connect()
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect("192.168.1.5", 49413);

            NetworkStream stream = tcpClient.GetStream(); //Underlying stream
            // There exist two solutions:  classes stream reader, stream writer
            // and classes binary reader, binary writer
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);

            streamWriter.AutoFlush = true;

            /*streamWriter.WriteLine("Hello...");*/// here message did not send
            // we use streamWriter.Flush to send it
            //streamWriter.Flush(); 

            btnSend.Enabled = true;

            while (true)
            {
                String msg = await streamReader.ReadLineAsync();
                txtRecievedMsgs.Text += $"{Environment.NewLine} {msg}";
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            streamWriter.WriteLine(txtMsgs.Text);
        }
    }
}
