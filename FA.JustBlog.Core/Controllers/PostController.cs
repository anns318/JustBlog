using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.ModelRepository;
using FA.JustBlog.Core.Service.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FA.JustBlog.Core.Controllers
{
    [AllowAnonymous]
    public class PostController : Controller
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly ILogger _logger;
        private readonly BlogContext _ctx;
        private readonly UserManager<User> _userManager;
        public PostController(IUnitOfWork unitOfWork, ILogger<PostController> logger,BlogContext blogContext, UserManager<User> userManager)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;
            _ctx = blogContext;
            _userManager = userManager;
        }
        public IActionResult PostDetail(int year, int month, string title)
        {
            var post = unitOfWork.postRepository.FindPost(year, month, title);
            return View(post);
        }
        public IActionResult Search(string search)
        {
            var list = from x in _ctx.Posts select x;
            var user = _userManager.GetUserAsync(User).GetAwaiter().GetResult();
            if(user == null)
            {
                list = list.Where(x => x.Title.Contains(search) || x.ShortDescription.Contains(search));
                return View(list.ToList());

            }
            var userRole = _userManager.GetRolesAsync(user).Result;
            if(userRole.Contains("Admin") || userRole.Contains("BlogOwner"))
            {
                list = list.Where(x => x.Title.Contains(search) || x.ShortDescription.Contains(search) || x.Content.Contains(search));

            }
            else
            {
                list = list.Where(x => x.Title.Contains(search) || x.ShortDescription.Contains(search));

            }
            return View(list.ToList());
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
