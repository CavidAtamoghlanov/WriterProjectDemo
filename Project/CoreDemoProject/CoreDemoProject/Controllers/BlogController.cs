using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.Controllers
{
    public class BlogController : Controller
    {
            BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = blogManager.GetAllWithCategory();
            return View(values);
        }


        public IActionResult BlogReadAll(int id)
        {
            var values = blogManager.GetBlogByID(id);
            ViewBag.i = id;
            return View(values);
        }
    }
}
