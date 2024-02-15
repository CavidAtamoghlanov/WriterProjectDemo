using ClosedXML.Excel;
using CoreDemoProject.Areas.Admin.Models;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoreDemoProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog Id";
                worksheet.Cell(1, 2).Value = "Blog Name";

                int BlogRowCount = 2;


                foreach (var blog in GetBlogModelsDynamic())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = blog.Id;
                    worksheet.Cell(BlogRowCount, 2).Value = blog.BlogName;
                    BlogRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BlogList.xlsx");
                }
            }

            return View();
        }

        ICollection<BlogModel> GetBlogModelsDynamic()
        {
            List<BlogModel> blogModels = new List<BlogModel>();
            using (var context = new MyAppDbContext())
            {
                blogModels = context.Blogs.Select(b => new BlogModel
                {
                    Id = b.BlogID,
                    BlogName = b.BlogTitle
                }).ToList();
            }
            return blogModels;
        }

        ICollection<BlogModel> GetBlogList()
        {
            List<BlogModel> blogModels = new();
            blogModels.Add(new BlogModel { Id = 1, BlogName = "Blog 1" });
            blogModels.Add(new BlogModel { Id = 2, BlogName = "Blog 2" });
            blogModels.Add(new BlogModel { Id = 3, BlogName = "Blog 3" });
            blogModels.Add(new BlogModel { Id = 4, BlogName = "Blog 4" });
            blogModels.Add(new BlogModel { Id = 5, BlogName = "Blog 5" });
            return blogModels;
        }


        public IActionResult BlogListExcel()
        {
            return View();
        }
    }
}
