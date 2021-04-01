using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    [Table("tblEmployee")]
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int EmployeeNumber { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeMiddleName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeGovernmentID { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
    }
}
