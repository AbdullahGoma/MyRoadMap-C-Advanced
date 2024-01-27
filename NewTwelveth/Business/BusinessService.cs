using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Data;

namespace Business
{
    public class BusinessService
    {
        public static List<Department> Departments
        {
            get
            {
                DataTable dataTable = DataHelper.GetDepartments();
                List<Department> departments = new List<Department>();
                foreach (DataRow row in dataTable.Rows)
                {
                    departments.Add(new Department()
                    {
                        ID = Convert.ToInt32(row["Dnumber"]),
                        Name = Convert.ToString(row["Dname"]),
                        //Employees = DataHelper.GetDepartmentsEmployees(id);
                    });
                }
                return departments;
            }
        }

        public static List<Employee> Employees
        {
            get
            {
                DataTable dataTable = DataHelper.GetEmployees();
                List<Employee> employees = new List<Employee>();
                foreach (DataRow row in dataTable.Rows)
                {
                    employees.Add(new Employee()
                    {
                        ID = Convert.ToInt32(row["SSN"]),
                        Name = Convert.ToString(row["Fname"]),
                    });
                }
                return employees;
            }
        }

        public static List<Employee> GetDepartmentsEmployees(int id)
        {
            DataTable dataTable = DataHelper.GetDepartmentsEmployees(id);
            List<Employee> employees = new List<Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                employees.Add(new Employee()
                {
                    ID = Convert.ToInt32(row["SSN"]),
                    Name = Convert.ToString(row["Fname"]),
                });
            }
            return employees;
        }


    }
}
