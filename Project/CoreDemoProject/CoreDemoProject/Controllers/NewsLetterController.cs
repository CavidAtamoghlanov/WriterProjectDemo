using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager newsLetterManager = new NewsLetterManager(new EfNewsLetterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult SubscribeMail(NewLetter p)
        {
            p.MailStatus = true;
            newsLetterManager.AddNewsLetter(p);   
            return PartialView();
        }
    }
}
