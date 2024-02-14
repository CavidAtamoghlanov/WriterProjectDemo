using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstracts
{
    public interface IMessage2Dal:IGenericDal<Message2>
    {
        ICollection<Message2> GetAllWithMessage2ByWriter(int id);
    }
}
