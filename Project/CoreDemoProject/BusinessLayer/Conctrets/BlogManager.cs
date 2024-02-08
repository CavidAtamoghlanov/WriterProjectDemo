using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conctrets
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }





        public ICollection<Blog> GetLast3Blog()
        {
            return _blogDal.GetAll().Take(3).ToList();
        }



        public ICollection<Blog> GetAllWithCategory()
        {
            return _blogDal.GetAllWithCategory();
        }

        public ICollection<Blog> GetAllWithCategoryByWriter(int id)
        {
            return _blogDal.GetAllWithCategoryByWriter(id);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public ICollection<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetAll(x => x.BlogID == id);
        }



        public ICollection<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetAll(x => x.WriterID == id);
        }

        public ICollection<Blog> GetList()
        {
            return _blogDal.GetAll();
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }
    }
}
