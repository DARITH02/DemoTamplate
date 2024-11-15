using Microsoft.AspNetCore.Mvc;

namespace DemoThemplate.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
