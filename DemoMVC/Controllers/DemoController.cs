using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
//Tran Thi Kim Dung - 2021050135
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Index(string hoTen, int tuoi)
        {
             string strResult = "Sinh vien " + hoTen + " " + tuoi + " tuoi";
            ViewBag.thongBao = strResult; 
            return View(); 
        }
    }
}