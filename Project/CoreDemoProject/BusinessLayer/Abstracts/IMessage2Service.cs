using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface IMessage2Service: IGenericService<Message2>
    {
        ICollection<Message2> GetInboxListByWriter(int id);


    }

}
