using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.ModelRepository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FA.JustBlog.Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository _postRepository;
        public HomeController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IActionResult Index()
        {
            List<Post> list = _postRepository.GetAll();
            return View(list.OrderByDescending(x => x.CreatedDate));
            
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
