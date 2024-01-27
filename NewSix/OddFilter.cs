using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSix
{
    internal class OddFilter : IFilter
    {
        public bool Check(int item)
        {
            return item % 2 != 0;
        }
    }
}
