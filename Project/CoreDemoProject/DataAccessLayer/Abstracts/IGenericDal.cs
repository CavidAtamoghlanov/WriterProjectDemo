using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstracts
{
    public interface IGenericDal<T> where T : class
    {
        ICollection<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        ICollection<T> GetAll(Expression<Func<T, bool>> filter);
    }
}
