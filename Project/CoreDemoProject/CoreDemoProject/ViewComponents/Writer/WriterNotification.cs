using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        NotificationManager notificationManager = new NotificationManager(new EfNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var values = notificationManager.GetList();
            return View(values);
        }
    }
}
