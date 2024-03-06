using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Index(string a)
        {
             string strResult = "Du lieu vua nhap la " + a;
            ViewBag.thongBao = strResult; 
            return View(); 
        }
    }
}