using Microsoft.AspNetCore.Mvc;

namespace MVC_2.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();//HTML Page
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
