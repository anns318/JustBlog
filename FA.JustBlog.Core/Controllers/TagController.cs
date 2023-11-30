using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.ModelRepository;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Core.Controllers
{
    public class TagController : Controller
    {
        private readonly ITagRepository tagRepository;

        public TagController(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }

        public IActionResult PopularTags()
        {
            //List<Tag> tags = tagRepository.GetAll()

            return PartialView("_PopularTags",tagRepository.GetAll().Take(10).ToList());
        }
    }
}
