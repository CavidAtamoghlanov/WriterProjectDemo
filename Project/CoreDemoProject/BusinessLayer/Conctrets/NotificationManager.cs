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
    public class NotificationManager : INotificationService
    {
        INotificationDal _notoficationDal;

        public NotificationManager(INotificationDal notoficationDal)
        {
            _notoficationDal = notoficationDal;
        }

    
        public Notification GetById(int id)
        {
            return _notoficationDal.GetById(id);
        }

        public ICollection<Notification> GetList()
        {
            return _notoficationDal.GetAll();
        }

        public void TAdd(Notification t)
        {
            _notoficationDal.Insert(t);
        }

        public void TDelete(Notification t)
        {
            _notoficationDal.Delete(t);
        }

        public void TUpdate(Notification t)
        {
            _notoficationDal.Update(t);
        }
    }
}
