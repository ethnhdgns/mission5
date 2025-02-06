using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mission5.Models;

namespace mission5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}