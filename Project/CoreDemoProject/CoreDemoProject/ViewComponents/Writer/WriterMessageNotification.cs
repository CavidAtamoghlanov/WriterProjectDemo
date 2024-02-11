using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        MessageManager MessageManager = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            string p;
            p = "cavid@gmail.com";
            var messageList = MessageManager.GetInboxListByWriter(p);
            return View(messageList);
        }
    }
}
