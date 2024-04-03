using BasicDotNetMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BasicDotNetMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            StudentModel student = new StudentModel
            {
                FirstName = "Arpit",
                LastName = "Dhuriya",
                Age = 23,
                Email = "arpit.dhuriya@nagarro.com"
            };
            return View(student);
        }

        public IActionResult Privacy()
        {
            return View("Privacy"); // Set the view name explicitly
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var requestId = Activity.Current?.Id ?? HttpContext?.TraceIdentifier;
            var errorViewModel = new ErrorViewModel { RequestId = requestId ?? "Unknown" };
            return View(errorViewModel);
        }
    }
}