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
            ViewBag.thongBao = "Họ Tên " + person.FullName + " địa chỉ " + person.Address ;
            return View(person); 
        }
    }
}
// Tran Thi Kim Dung-2021050135