using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewThird
{
    // Multi Level Inheritance
    internal class Employee : Human
    {
        //public int Salary;

        private int salary;
        // Property is an alternative to function set and get
        //and this achieve the logic of functionality "Implement business logic"
        public int Salary
        {
            private get
            {
                return salary;
            }
            set
            {
                if (value > 3000) this.salary = value;
                else this.salary = 3000;
            }
        }



        // Here calling function move from Human only,
        // because it hide function move from Creature
        // Then base function here is Move from Human
        public override void Move()
        {
            Console.WriteLine("Employee is moving...");
        }




        // Property is an alternative to function set and get
        //public int GetSalary()
        //{
        //    return salary;
        //}

        //public void SetSalary(int value)
        //{
        //    if (value > 3000) this.salary = value;
        //    else this.salary = 3000;
        //}


    }
}
