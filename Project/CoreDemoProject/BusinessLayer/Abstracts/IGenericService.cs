using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface IGenericService<T>
    {
        ICollection<T> GetList();
        void TAdd(T t);
        void TUpdate(T t);
        void TDelete(T t);
        T GetById(int id);
    }
}
