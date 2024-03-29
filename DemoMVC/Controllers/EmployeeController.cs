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
            
            ViewBag.Message = "Thông tin nhân viên: " + employee.EmployeeId + " tuoi " + employee.Age;
            return View(employee);
        }
    }
}