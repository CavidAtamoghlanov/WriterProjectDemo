using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager _message2Manager = new Message2Manager(new EfMessage2Repository());
        
        public IActionResult InBox()
        {
            int id = 2;
            var messageList = _message2Manager.GetInboxListByWriter(id);
            return View(messageList);
        }

        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var messageValue = _message2Manager.GetById(id);
            return View(messageValue);
        }
    }
}
