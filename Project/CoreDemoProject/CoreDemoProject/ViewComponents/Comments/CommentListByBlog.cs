using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.ViewComponents.Comments
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager _commentManager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int blogId)
        {
            var values = _commentManager.GetAll(blogId);
            return View(values);
        }
    }
}
