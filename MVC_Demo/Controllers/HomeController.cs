using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MVC()
        {
            var model = new MVCModel();
            model.Hello = "Hello World";
            return View(model);
        }

        public IActionResult MVP()
        {
            return View();
        }

        public IActionResult Fat()
        {
            return View();
        }

        public IActionResult SmartUI()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
