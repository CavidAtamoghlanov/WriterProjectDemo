using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
