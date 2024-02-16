using CoreDemoProject.Areas.Admin.Models;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemoProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult CategoryChart()
        {
            List<CategoryClass> categoryClasses = new List<CategoryClass>();

            categoryClasses.Add(new CategoryClass()
            {
                CategoryCount = 10,
                CategoryName = "Category 1"
            });

            categoryClasses.Add(new CategoryClass()
            {
                CategoryCount = 20,
                CategoryName = "Category 2"
            });

            categoryClasses.Add(new CategoryClass()
            {
                CategoryCount = 30,
                CategoryName = "Category 3"
            });

            return Json(new { jsonlist = categoryClasses });
        }


    }
}
