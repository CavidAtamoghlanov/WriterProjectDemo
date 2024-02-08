using DataAccessLayer.Abstracts;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.MyEntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {


        public ICollection<Blog> GetAllWithCategory()
        {
            using (var context = new MyAppDbContext())
            {
                return context.Blogs.Include(c=>c.Category).ToList();
            }
        }

        public ICollection<Blog> GetAllWithCategoryByWriter(int id)
        {
            using (var context = new MyAppDbContext())
            {
                return context.Blogs.Include(c => c.Category).Where(x => x.WriterID == id).ToList();
            }   
        }
    }
}
