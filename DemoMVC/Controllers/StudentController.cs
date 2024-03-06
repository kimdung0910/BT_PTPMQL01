using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
//Tran Thi Kim Dung - 2021050135
namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View(new Student()); 
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
           
            ViewBag.Message = "Thông tin sinh viên: " + student.FullName;
            return View(student);
        }
    }
}