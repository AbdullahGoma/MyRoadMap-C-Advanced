using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataHelper
    {
        static SqlConnection sqlConnection = new SqlConnection("Data source =ABDULLAH; Database = Second;integrated security = True;TrustServerCertificate=True"); //;TrustServerCertificate=False

        public static DataTable GetDepartments()
        {
            SqlCommand sqlCommand = new SqlCommand("select Dnumber, Dname from Department", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable GetEmployees()
        {
            SqlCommand sqlCommand = new SqlCommand("select SSN, Fname from Employee", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable GetDepartmentsEmployees(int deptID)
        {
            SqlCommand sqlCommand = new SqlCommand("select SSN, Fname from Employee where Dno == deptID", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

    }
}
