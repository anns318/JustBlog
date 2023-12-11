using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.ModelRepository;
using FA.JustBlog.Core.Service.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Core.Controllers
{
    [AllowAnonymous]
    public class PostController : Controller
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly ILogger _logger;
        public PostController(IUnitOfWork unitOfWork, ILogger<PostController> logger)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;
        }
        public IActionResult PostDetail(int year, int month, string title)
        {
            var post = unitOfWork.postRepository.FindPost(year, month, title);
            return View(post);
        }
        public IActionResult MostViewedPosts()
        {
            _logger.LogInformation("Get most view post");
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
