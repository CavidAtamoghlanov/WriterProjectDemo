using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        //void UpdateComment(Comment comment);
        //void DeleteComment(Comment comment);
        //Comment GetById(int id);
        ICollection<Comment> GetAll(int id);

    }
}
