using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSix
{
    internal class Helper
    {
        public static bool IsEven(int item)
        {
            return item % 2 == 0;
        }
        public bool IsOdd(int item)
        {
            return item % 2 != 0;
        }
    }
}
