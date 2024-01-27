using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewForth
{
    internal class Manager:Employee
    {
        public override void Move()
        {
            Console.WriteLine($"Manager is moving with speed = {Speed}...");
        }
    }
}
