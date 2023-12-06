using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.ModelRepository;
using FA.JustBlog.Core.Service.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Core.Controllers
{
    public class PostController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public PostController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult PostDetail(int year, int month, string title)
        {
            var post = unitOfWork.postRepository.FindPost(year, month, title);
            return View(post);
        }
        public IActionResult MostViewedPosts()
        {
            List<Post> list = unitOfWork.postRepository.Find(x=>x.IsPublished).OrderByDescending(x => x.View).Take(5).ToList();
            return PartialView("_ListPost", list);
        }
        public IActionResult LatestPosts()
        {
            List<Post> list = unitOfWork.postRepository.Find(x => x.IsPublished).OrderByDescending(x => x.CreatedDate).Take(5).ToList();
            return PartialView("_ListPost", list);
        }
    }
}
