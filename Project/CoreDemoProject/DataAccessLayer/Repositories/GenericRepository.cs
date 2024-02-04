using DataAccessLayer.Abstracts;
using DataAccessLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T entity)
        {
            using var context = new MyAppDbContext();
            context.Remove(entity);
            context.SaveChanges();
        }

        public ICollection<T> GetAll()
        {
            using var context = new MyAppDbContext();
            return context.Set<T>().ToList();
        }

		public ICollection<T> GetAll(Expression<Func<T, bool>> filter)
		{
			using var context = new MyAppDbContext();
            return context.Set<T>().Where(filter).ToList();
		}

		public T GetById(int id)
        {
            using var context = new MyAppDbContext();
            return context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            using var context = new MyAppDbContext();
            context.AddAsync(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            using var context = new MyAppDbContext();
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
