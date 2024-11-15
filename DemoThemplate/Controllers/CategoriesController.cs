using Microsoft.AspNetCore.Mvc;

namespace DemoThemplate.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Phone()
        {
            return View();
        }
        public IActionResult Laptop() {
        return View();
        }
    }
}
