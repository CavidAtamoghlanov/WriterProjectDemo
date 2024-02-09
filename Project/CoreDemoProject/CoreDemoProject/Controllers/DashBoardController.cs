using BusinessLayer.Conctrets;
using DataAccessLayer.Contexts;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemoProject.Controllers
{
    public class DashBoardController : Controller
    {
        BlogManager BlogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            MyAppDbContext context = new MyAppDbContext();
            ViewBag.BlogCount = context.Blogs.Count().ToString();
            ViewBag.WriterBlogCount = context.Blogs.Where(x => x.WriterID == 1).Count().ToString();
            ViewBag.CategoryCount = context.Categories.Count().ToString();
            return View();
        }
    }
}
