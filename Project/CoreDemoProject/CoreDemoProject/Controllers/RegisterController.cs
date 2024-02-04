using BusinessLayer.Conctrets;
using BusinessLayer.ValidationRules;
using DataAccessLayer.MyEntityFramework;
using EntityLayer.Concretes;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.Controllers
{
    public class RegisterController : Controller
    {

        WriterManager _writerManager = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidator validationRules = new WriterValidator();

            ValidationResult result = validationRules.Validate(writer);

            if (result.IsValid)
            {
                writer.WriterStatus = true;
                writer.WriterAbout = "Deneme";
                _writerManager.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }   

            return View();
		}
    }
}
