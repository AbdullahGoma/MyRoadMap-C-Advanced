using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSix
{
    internal class PositiveFilter : IFilter
    {
        public bool Check(int item)
        {
            return item > 0;
        }
    }
}
