using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class SinhVienController : Controller
    {
        public IActionResult Index()
        {
            return View(new SinhVien()); 
        }

        [HttpPost]
        public IActionResult Index(SinhVien sinhVien)
        {
           
            ViewBag.Message = "Thông tin sinh viên: " + sinhVien.HoTen;
            return View(sinhVien);
        }
    }
}
//Tran Thi Kim Dung - 2021050135