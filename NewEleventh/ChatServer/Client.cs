using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    //Publisher
    internal class Client
    {
        public event EventHandler<string> MsgReceived;
        TcpClient tcpClient;
        StreamReader streamReader;
        StreamWriter streamWriter;

        public Client(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;
            NetworkStream stream = tcpClient.GetStream(); //Underlying stream
            // There exist two solutions:  classes stream reader, stream writer
            // and classes binary reader, binary writer
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            streamWriter.AutoFlush = true;

            ReadMsg();
        }

        public void SendMsg(string msg)
        {
            streamWriter.WriteLine(msg);
        }

        public async void ReadMsg()
        {
            //streamReader.ReadLine();
            while (true)
            {
                String msg = await streamReader.ReadLineAsync();
                //txtRecievedMsgs.Text += $"{Environment.NewLine} {msg}";
                if(MsgReceived != null) MsgReceived(this, msg); 
            }
        }


    }
}
