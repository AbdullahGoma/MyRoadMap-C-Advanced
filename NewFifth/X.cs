using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFifth
{
    internal class X
    {
        int a;
        //Y y;

        public X()
        {
            //y = new Y();
            //y.b; // Error Here
        }


        class Y
        {
            int b;
            X x;
            public Y() 
            {
                x = new X();
                x.a = 1; // Access Private memeber here
            }  
        }


    }
}
