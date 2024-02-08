﻿using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstracts
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        ICollection<Blog> GetAllWithCategory();
        ICollection<Blog> GetAllWithCategoryByWriter(int id);
    }
}
