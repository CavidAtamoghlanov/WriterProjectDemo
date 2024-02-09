using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {
        BlogManager BlogManager = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = BlogManager.GetAllWithCategory();
            return View(values);
        }
    }
}
