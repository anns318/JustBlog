using FA.JustBlog.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Controllers
{
    public class CommentController : Controller
    {
        private readonly BlogContext _context;
        public CommentController(BlogContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SaveComment(Comment comment,string returnUrl)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();

            var post = await _context.Posts.Include(x=>x.Comment).FirstOrDefaultAsync(x => x.Id == comment.PostId);
            List<Comment> comments = post.Comment;
            return ViewComponent("Comment", new { comments, PostId = comment.PostId });
        }
    }
}
