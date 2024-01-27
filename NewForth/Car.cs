using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewForth
{
    internal class Car : IMovable
    {
        public int Number { get; set; }
        public string Brand { get; set; }
        public int Speed { get; set; }

        // Must do this function, Must be public "by default public"
        public void Move()
        {
            Console.WriteLine($"Car is moving with speed = {Speed}...");
        }

    }
}
