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

		public void AddBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

		public ICollection<Blog> AllCategory()
		{
			return _blogDal.GetAll();
		}

		public ICollection<Blog> GetLast3Blog()
		{
			return _blogDal.GetAll().Take(3).ToList();
		}

		public void DeleteBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

        public ICollection<Blog> GetAllWithCategory()
        {
			return _blogDal.GetAllWithCategory();
        }

        public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}

		public ICollection<Blog> GetBlogByID(int id)
		{
			return _blogDal.GetAll(x => x.BlogID == id);
		}

		public void UpdateBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

        public ICollection<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetAll(x => x.WriterID == id);
        }
    }
}
