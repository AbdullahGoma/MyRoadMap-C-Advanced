using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFifth
{
    internal class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"ID = {Id} \t Name = {Name}";
        }
    }
}
