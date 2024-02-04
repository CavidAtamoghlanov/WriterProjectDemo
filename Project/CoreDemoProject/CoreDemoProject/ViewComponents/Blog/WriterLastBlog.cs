using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.ViewComponents.Blog
{
    public class WriterLastBlog:ViewComponent
    {
        BlogManager BlogManager = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = BlogManager.GetBlogListByWriter(2);
            return View(values);
        }
    }
}
