using BusinessLayer.Conctrets;
using BusinessLayer.ValidationRules;
using CoreDemoProject.Models;
using DataAccessLayer.Contexts;
using DataAccessLayer.MyEntityFramework;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;

namespace CoreDemoProject.Controllers
{
    [Authorize]
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        MyAppDbContext context = new MyAppDbContext();

        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.usermail = usermail;

            var writerName = context.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.writerName = writerName;
            return View();
        }


        public IActionResult WriterProfile()
        {
            return View();
        }


        public IActionResult WriterMail()
        {
            return View();
        }


        public IActionResult Test()
        {
            return View();
        }

        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var usermail = User.Identity.Name;
            var writerid = context.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var writerValues = writerManager.GetById(writerid);
            return View(writerValues);
        }


        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            WriterValidator validationRules = new WriterValidator();
            var result = validationRules.Validate(p);
            if (result.IsValid)
            {
                writerManager.TUpdate(p);
                return RedirectToAction("Index", "DashBoard");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer writer = new Writer();

            if (p.WriterImage != null)
            {
                var extention = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extention;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/" + newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                writer.WriterImage = newimagename;
            }

            writer.WriterName = p.WriterName;
            writer.WriterAbout = p.WriterAbout;
            writer.WriterMail = p.WriterMail;
            writer.WriterPassword = p.WriterPassword;
            writer.WriterStatus = p.WriterStatus;
            writerManager.TAdd(writer);
            return View();
        }
    }
}
