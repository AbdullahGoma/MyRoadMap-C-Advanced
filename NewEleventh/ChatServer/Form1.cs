using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        List<Client> clients;
        public Form1()
        {
            InitializeComponent();

            clients = new List<Client>();
        }

        private async void Start()
        {
            //IPAddress ip = new IPAddress(new byte[] { 192, 168, 1, 5 });
            IPAddress ip = IPAddress.Parse("192.168.1.5"); //127.0.0.1 or localhost
            // Listen to the traffics on network and recieve requests from clients
            TcpListener tcpListener = new TcpListener(ip, 49413);
            tcpListener.Start();


            while (true)
            {
                TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
                //AcceptTcpClientAsync Blocking Function, and it work in thread
                Client client = new Client(tcpClient);
                client.MsgReceived += Client_MsgRecieved;
                clients.Add(client);
                btnSend.Enabled = true;
            }

            //MessageBox.Show("Client Connected");
            // If Client and Server are connected then Sream open between them
            
            //btnSend.Enabled = true;
        }

        private void Client_MsgRecieved(object sender, string msg)
        {
            txtRecievedMsgs.Text += $"{Environment.NewLine} {msg}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //streamWriter.WriteLine(txtMsgs.Text);
            foreach (Client client in clients)
            {
                client.SendMsg(txtMsgs.Text);
            }
        }

    }
}
