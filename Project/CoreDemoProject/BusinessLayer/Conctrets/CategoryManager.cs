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



        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public ICollection<Category> GetList()
        {
            return _categoryDal.GetAll();
        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
