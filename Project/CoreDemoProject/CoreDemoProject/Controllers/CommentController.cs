using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemoProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentCreateDate = DateTime.Parse(System.DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogID = 2;

            commentManager.AddComment(comment);
            return PartialView();
        }


        public PartialViewResult CommentListByBlog(int id)
        {
            var values = commentManager.GetAll(id);
            
            return PartialView("CommentListByBlog", values);
        }
    }
}
