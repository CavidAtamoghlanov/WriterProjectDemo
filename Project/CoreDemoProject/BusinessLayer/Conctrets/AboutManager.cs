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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
            _aboutDal = aboutDal;
            _aboutDal = aboutDal;
            _aboutDal = aboutDal;
            _aboutDal = aboutDal;
        }

   

        public About GetById(int id)
        {
           return _aboutDal.GetById(id);
        }

        public ICollection<About> GetList()
        {
            return _aboutDal.GetAll();
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
           _aboutDal.Delete(t);
        }

        public void TUpdate(About t)
        {
           _aboutDal.Update(t);
        }
    }
}
