using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.ViewComponents.Category
{
    public class CategoryListDashboard:ViewComponent
    {
        CategoryManager CategoryManager = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = CategoryManager.GetList();
            return View(values);
        }
    }
}
