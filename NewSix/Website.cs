using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSix
{
    internal class Website
    {
        //List<INotifiable> subscribers;
        //public Action MsgArrived; // Function did not take any thing and did not return anything
        public event Action<object, MsgEventArgs> MsgArrived; // Function take string and return nothing
        public void AddNews(string info)
        {
            if (MsgArrived != null) MsgArrived(this, new MsgEventArgs { Msg = info, Journalist = "Abdullah"}); // Invoke
        }


    }

    class MsgEventArgs : EventArgs
    {
        public string Msg { get; set; }
        public string Journalist { get; set; }

    }
}
