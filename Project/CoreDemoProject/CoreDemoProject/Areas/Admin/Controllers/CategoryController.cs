using BusinessLayer.Conctrets;
using BusinessLayer.ValidationRules;
using DataAccessLayer.MyEntityFramework;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using X.PagedList;

namespace CoreDemoProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page = 1)
        {
            var values = categoryManager.GetList().ToPagedList(page, 3);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {

            return View();
        }


        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
           


            CategoryValidator validationRules = new CategoryValidator();
            var result = validationRules.Validate(category);



            if (result.IsValid)
            {
                category.CategoryStatus=true;
                categoryManager.TAdd(category);


           
                return RedirectToAction("Index", "Category");
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

        [HttpGet]
        public IActionResult CategoryDelete(int id)
        {

            var categoryValue = categoryManager.GetById(id);
            categoryManager.TDelete(categoryValue);
            return RedirectToAction("Index");
        }

    }
}
