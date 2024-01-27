using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSix
{
    internal class Magazine
    {
        //List<INotifiable> subscribers;
        public void WebsiteSentAMessage(object sender, MsgEventArgs args)
        {
            Console.WriteLine($"In Magazine: {args.Msg}");
        }
    }
}
