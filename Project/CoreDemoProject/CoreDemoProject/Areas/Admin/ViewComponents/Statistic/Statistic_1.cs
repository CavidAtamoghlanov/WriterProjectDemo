using BusinessLayer.Conctrets;
using DataAccessLayer.Contexts;
using DataAccessLayer.MyEntityFramework;
using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoreDemoProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic_1:ViewComponent
    {
        BlogManager BlogManager = new BlogManager(new EfBlogRepository());
        MyAppDbContext context = new MyAppDbContext();
            public IViewComponentResult Invoke()
        {
            var count = BlogManager.GetList().Count;
            ViewBag.count = count;
            ViewBag.ContactCount = context.Contacts.Count();
            ViewBag.CommentCount = context.Comments.Count();
            string api = "0d4bc9bc491c2458ac9cd7bae632bebd";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=London&mode=xml&lang=tr&units=metric&appid="+api;

            //XDocument document = XDocument.Load(connection);
            //ViewBag.weather = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();
        }
    }
}
