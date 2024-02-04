using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager CategoryManager = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = CategoryManager.AllCategory();
            return View(values);
            
        }
    }
}
