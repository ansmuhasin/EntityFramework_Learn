using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["Learning_DBConnection"].ConnectionString).ConnectionString;
            DBContextForLearningDB entity = new DBContextForLearningDB(connectionString);
            Employee employee = new Employee
            { DateOfBirth = new DateTime(),
                Department = "Payroll",
                EmployeeFirstName = "Ans",
                EmployeeGovernmentID = "55829319797",
                EmployeeLastName = "Abd",
                EmployeeMiddleName = "Muh",
                EmployeeNumber = 103
            };
            Employee e = entity.Employees.FirstOrDefault();
            entity.Employees.Add(employee);
            entity.SaveChanges();

        }
    }
}
