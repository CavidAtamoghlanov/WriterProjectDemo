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
    public class EfMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {
        public ICollection<Message2> GetAllWithMessage2ByWriter(int id)
        {
            using (var context = new MyAppDbContext
                ())
            {
                return context.Message2s.Include(x => x.Sender).Where(x => x.ReceiverId == id).ToList();
            }
        }
    }
}
