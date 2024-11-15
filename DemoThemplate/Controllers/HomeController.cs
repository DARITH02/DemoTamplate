using DemoThemplate.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoThemplate.Controllers
{
    public class HomeController : Controller
    {
   public IActionResult Index()
        {
            return View();
        }
    }
}
