using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemoProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic_4:ViewComponent
    {
        MyAppDbContext context = new MyAppDbContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.Admin = context.Admins.Where(x => x.AdminID == 1).Select(x => x.Name).FirstOrDefault() ;
            ViewBag.AdminImage = context.Admins.Where(x => x.AdminID == 1).Select(x => x.ImageURL).FirstOrDefault();

            ViewBag.ShortDescription = context.Admins.Where(x => x.AdminID == 1).Select(x => x.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}
