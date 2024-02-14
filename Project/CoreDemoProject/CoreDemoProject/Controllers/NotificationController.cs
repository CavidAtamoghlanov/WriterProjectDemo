using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager NotificationManager = new NotificationManager(new EfNotificationRepository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllNotification()
        {
            var notifications = NotificationManager.GetList();
            return View(notifications);
        }
    }
}
