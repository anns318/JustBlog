using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.ModelRepository;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Core.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public IActionResult MostViewedPosts()
        {
            List<Post> list = _postRepository.GetAll().OrderByDescending(x=>x.View).Take(5).ToList();
            return PartialView("_ListPost", list);
        }
        public IActionResult LatestPosts()
        {
            List<Post> list = _postRepository.GetAll().OrderByDescending(x => x.CreatedDate).Take(5).ToList();
            return PartialView("_ListPost", list);
        }
    }
}
