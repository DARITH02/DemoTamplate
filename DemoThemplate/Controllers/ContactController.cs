using Microsoft.AspNetCore.Mvc;

namespace DemoThemplate.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
