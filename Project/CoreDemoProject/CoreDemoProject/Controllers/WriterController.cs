using BusinessLayer.Conctrets;
using BusinessLayer.ValidationRules;
using CoreDemoProject.Models;
using DataAccessLayer.MyEntityFramework;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace CoreDemoProject.Controllers
{
	[Authorize]
	public class WriterController : Controller
	{
		WriterManager writerManager = new WriterManager(new EfWriterRepository());
		public IActionResult Index()
		{
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
			var writerValues = writerManager.GetById(1);
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
				return RedirectToAction("Index","DashBoard");
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

			if(p.WriterImage!=null)
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
