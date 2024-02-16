using CoreDemoProject.Areas.Admin.Models;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoreDemoProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }


        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id = 1,
                Name = "Writer 1"
            },
            new WriterClass
            {
                Id = 2,
                Name = "Writer 2"
            },
            new WriterClass
            {
                Id = 3,
                Name = "Writer 3"
            },
            new WriterClass
            {
                Id = 4,
                Name = "Writer 4"
            }
        };


    }
}
