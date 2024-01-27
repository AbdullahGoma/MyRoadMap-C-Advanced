using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTen
{
    internal class Helper
    {
        bool finished = false;  
        object locker = new object();
        public void PrintMsg()
        {
            //bool finished = false;
            lock (locker)
            {
                if (!finished)
                {
                    finished = true; //This code not thread safe, because different in time
                    Console.WriteLine("Hellllllo");
                    //finished = true; //This code not thread safe,
                }
            }
            
        }
    }
}
