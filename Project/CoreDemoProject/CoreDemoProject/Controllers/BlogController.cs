using BusinessLayer.Conctrets;
using BusinessLayer.ValidationRules;
using DataAccessLayer.MyEntityFramework;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemoProject.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = blogManager.GetAllWithCategory();
            return View(values);
        }


        public IActionResult BlogReadAll(int id)
        {
            var values = blogManager.GetBlogByID(id);
            ViewBag.i = id;
            return View(values);
        }


        public IActionResult BlogListByWriter()
        {
            var values = blogManager.GetAllWithCategoryByWriter(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            allcategoryForSelect();
            return View();
        }

        private void allcategoryForSelect()
        {
           
            CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryValues = (from x in categoryManager.GetList().ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();

            ViewBag.cv = categoryValues;
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {


            allcategoryForSelect();

            BlogValidator validationRules = new BlogValidator();
            var result = validationRules.Validate(blog);

            if (result.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.WriterID = 1;
                blogManager.TAdd(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
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


        public IActionResult DeleteBlog(int id)
        {
            var blogValue = blogManager.GetById(id);
            blogManager.TDelete(blogValue);
            return RedirectToAction("BlogListByWriter", "Blog");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            allcategoryForSelect();
            var blogValue = blogManager.GetById(id);
            return View(blogValue);
        }

        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.BlogStatus = true;
            blogManager.TUpdate(blog);
            return RedirectToAction("BlogListByWriter", "Blog");
        }

    }
}
