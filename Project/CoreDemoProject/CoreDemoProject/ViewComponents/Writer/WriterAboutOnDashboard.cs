using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager _writerManager = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var writerList = _writerManager.GetWriterById(1);
            return View(writerList);
        }
    }
}
