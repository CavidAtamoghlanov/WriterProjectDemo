using BusinessLayer.Conctrets;
using DataAccessLayer.Contexts;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemoProject.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager _writerManager = new WriterManager(new EfWriterRepository());
            MyAppDbContext context = new MyAppDbContext();
        public IViewComponentResult Invoke()
        {
            var usermail  = User.Identity.Name;
            var writerid = context.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();

            var writerList = _writerManager.GetWriterById(writerid);
            return View(writerList);
        }
    }
}
