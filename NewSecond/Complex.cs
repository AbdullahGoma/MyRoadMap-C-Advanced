using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSecond
{
    struct Complex
    {
        //Access Modifiers = public or private .....
        public int Real;
        public int Img;

        //Error Here
        //public Complex() { }

        // Default constructor still exist (only in struct)
        public Complex(int Real, int Img)
        {
            // All fiels must be initialized
            this.Real = Real;
            this.Img = Img;
        }
    }
}
