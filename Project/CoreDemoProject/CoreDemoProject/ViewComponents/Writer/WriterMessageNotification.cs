using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        Message2Manager MessageManager = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id = 1 ;
            var messageList = MessageManager.GetInboxListByWriter(id);
            return View(messageList);
        }
    }
}
