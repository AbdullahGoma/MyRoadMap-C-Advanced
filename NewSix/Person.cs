using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSix
{
    internal class Person
    {
        public string Name { get; set; }

        // Is Subscriber can record him self to two publishers?
        // yes
        public void MsgHere(object sender, MsgEventArgs args) // We add object sender to know who is the publisher
        {
            Console.WriteLine($"{Name}: {args.Msg}");
        }


    }
}
