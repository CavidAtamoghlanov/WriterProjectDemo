using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.ViewComponents.Blog
{
	
	public class BlogLast3Post:ViewComponent
	{
		BlogManager BlogManager = new BlogManager(new EfBlogRepository());
		public IViewComponentResult Invoke()
		{
			var values = BlogManager.GetLast3Blog();
			return View(values);
		}
	}
}
