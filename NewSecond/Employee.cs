using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSecond
{
    internal class Employee
    {
        // All of this members in heap
        public int Id;
        public string Name;
        public double Salary;

        public Employee() : this(1, string.Empty)
        {
            // This is not in object, this in the function,
            // then it will be in stack and it will be gone when function is finished
            //int x; // Local Variable 
            //----------------
            //Id = 1;
            //Name = string.Empty; // != (Name = null) --> Null means reference does not (look) to any thing
            //                     // ,Empty means object (look) to object but object does not have string
            //===============
            //Employee(1, string.Empty); // not Work
            Salary = 5000;
        }

        public Employee(int id) : this(id, string.Empty)
        {
            //this.Id = id;
            //Name = string.Empty;
        }

        // Overloading Constructor
        public Employee(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
