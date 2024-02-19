using CoreDemoProject.Areas.Admin.Models;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

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

        public IActionResult GetWriterById(int writerId)
        {
            var writer = writers.Find(x => x.Id == writerId);
            var jsonWriter = JsonConvert.SerializeObject(writer);
            return Json(jsonWriter);
        }


        [HttpPost]
        public IActionResult AddWriter(WriterClass writer)
        {
            writers.Add(writer);
            return Json(writers);
        }


        [HttpGet]
        public IActionResult DeleteWriter(int writerId)
        {
            var writer = writers.Find(x => x.Id == writerId);
            writers.Remove(writer);
            return Json(writers);
        }

        [HttpPost]
        public IActionResult UpdateWriter(WriterClass writer)
        {
            var writerToUpdate = writers.Find(x => x.Id == writer.Id);
            writerToUpdate.Name = writer.Name;
            var jsonWriter = JsonConvert.SerializeObject(writerToUpdate);
            return Json(jsonWriter);
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
