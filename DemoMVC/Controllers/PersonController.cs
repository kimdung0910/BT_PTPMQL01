using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View(new Person()); 
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            ViewBag.thongBao = "Sinh vien " + person.FullName + " o " + person.Address +  " "+  person.Age + " tuoi"; 
            return View(person); 
        }
    }
}
// Tran Thi Kim Dung-2021050135