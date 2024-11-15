using Microsoft.AspNetCore.Mvc;

namespace DemoThemplate.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
