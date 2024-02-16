using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemoProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic_2:ViewComponent
    {
        MyAppDbContext context = new MyAppDbContext(); 
        public IViewComponentResult Invoke()
        {


            ViewBag.TakeEnd = context.Blogs.OrderByDescending(x=>x.BlogID).Select(x => x.BlogTitle).Take(1).FirstOrDefault();
            return View();
        }
    }
}
