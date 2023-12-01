using FA.JustBlog.Core.Service.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Core.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PostByCategory(string name)
        {
            var Post = unitOfWork.categoryRepository.PostByCategory(name);
            return View("~/Views/Post/_ListPost.cshtml",Post);
        }
    }
}
