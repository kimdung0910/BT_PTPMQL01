using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
//Tran Thi Kim Dung - 2021050135
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Employee()); 
        }

        [HttpPost]
        public IActionResult Index(Employee employee)
        {
            
            ViewBag.Message = "Thông tin nhân viên: " + employee.EmployeeName + " tuoi " + employee.Age + " muc luong " + employee.Salary;
            return View(employee);
        }
    }
}