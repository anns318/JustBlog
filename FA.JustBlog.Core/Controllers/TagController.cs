using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.ModelRepository;
using FA.JustBlog.Core.Service.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Core.Controllers
{
    public class TagController : Controller
    {   
        private readonly IUnitOfWork unitOfWork;
        public TagController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult PopularTags()
        {
            IEnumerable<PostTagCountVM> tags = unitOfWork.tagRepository.getPopularTag();

            return PartialView("_PopularTags", tags);
        }
        public IActionResult PostByTag(string name)
        {
            var listPost = unitOfWork.tagRepository.GetPostByTagName(name);
            return View("~/Views/Post/_ListPost.cshtml", listPost);
        }
    }
}
