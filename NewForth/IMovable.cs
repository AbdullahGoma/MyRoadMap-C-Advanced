using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewForth
{
    internal interface IMovable
    {
        int Speed { get; set; }  
        void Move();
    }
}
