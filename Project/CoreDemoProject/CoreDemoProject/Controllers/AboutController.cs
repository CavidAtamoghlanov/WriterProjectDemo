using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IActionResult Index ()
        {
           var values = aboutManager.GetList();
            return View(values);
        }


        public PartialViewResult SocialMediaAbout()
        {
			return PartialView();
		}


    }
}
