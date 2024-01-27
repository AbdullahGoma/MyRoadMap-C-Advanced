using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFifth
{
    internal class EmployeeList : List<Employee>
    {
        public new void Add(Employee e)
        {
            if(e.Salary >= 3000)
            {
                base.Add(e);
            }
        }
    }
}
