using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
