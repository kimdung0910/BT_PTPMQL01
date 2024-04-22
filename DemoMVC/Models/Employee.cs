using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//Tran Thi Kim Dung 2021050135
namespace DemoMVC.Models
{
    [Table("Employees")]
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public int Age { get; set; }
    }
}