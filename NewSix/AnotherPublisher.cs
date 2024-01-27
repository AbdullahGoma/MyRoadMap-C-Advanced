using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSix
{
    delegate void MyMsgDelegate(object sender, MsgEventArgs args);
    internal class AnotherPublisher
    {
        public event MyMsgDelegate MsgSent;
        public void AddInformation(string info)
        {
            if (MsgSent != null) MsgSent(this, new MsgEventArgs { Msg = info, Journalist = "Ahmed" }); // Invoke
        }
    }

}
