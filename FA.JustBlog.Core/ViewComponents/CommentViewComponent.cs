using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Core.ViewComponents
{
    public class CommentViewComponent : ViewComponent
    {
        private readonly IUnitOfWork unitOfWork;
        public CommentViewComponent(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public  IViewComponentResult Invoke(List<Comment> Comments,int PostId)
        {
            var item = new
            {
                comment = Comments,
                PostId = PostId
            };
            return View(item);
        }
    }
}
