using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using DataAccessLayer.MyEntityFramework;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Conctrets
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void AddCategory(Category category)
        {
            _categoryDal.Insert(category);      
        }

        public ICollection<Category> AllCategory()
        {
            return _categoryDal.GetAll();
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
         _categoryDal.Update(category);
        }
    }
}
