using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewForth
{
    internal class Employee : IMovable, ITestable //, IComparable<Employee> // Class Does not inherit from interface,
                                                               // Class implement interface
                                                               // Order is important
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Speed { get; set; }

        //public int CompareTo(Employee employee)
        //{
        //    //return -1 * Id.CompareTo(employee.Id);
        //    return -1 * employee.Name.CompareTo(Name);
        //}

        // Must do this function, Must be public "by default public"
        public virtual void Move()
        {
            Console.WriteLine($"Employee is moving with speed = {Speed}...");
        }

        public virtual void Test()
        {
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"ID = {Id} \t Name = {Name}";
        }

    }
}
