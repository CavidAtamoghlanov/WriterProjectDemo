using DataAccessLayer.Abstracts;
using DataAccessLayer.Repositories;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.MyEntityFramework
{
    public class EfAboutRepository:GenericRepository<About> , IAboutDal
    {
    }
}
