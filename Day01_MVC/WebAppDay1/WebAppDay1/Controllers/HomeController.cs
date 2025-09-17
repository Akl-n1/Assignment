using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppDay1.Models;

namespace WebAppDay1.Controllers
{
    public class HomeController : Controller
    {
        #region View Test
        //public ContentResult ShowMassage()
        //{
        //    var content = new ContentResult();
        //    content.Content = "Hello from HomeController";
        //    return content;
        //}
        //public ViewResult GetStudent()
        //{
        //    var View = new ViewResult();
        //    View.ViewName = "ShowStudent";
        //    return View;
        //}

        //public IActionResult ShowMix(int Id)
        //{
        //    if (Id % 2 == 0)
        //    {
        //        return Content("Hello Mahmoud");
        //    }
        //    else
        //    {
        //        return View("ShowStudent");
        //    }
        //} 
        #endregion

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
