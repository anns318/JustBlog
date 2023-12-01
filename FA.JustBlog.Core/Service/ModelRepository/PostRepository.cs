using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.Repository;

namespace FA.JustBlog.Core.Service.ModelRepository
{
    public class PostRepository : Repository<Post>, IPostRepository
    {

        public PostRepository(BlogContext ctx) : base(ctx)
        {

        }

        public Post FindPost(int year, int month, string title)
        {
            return ctx.Posts
                .Where(x => x.CreatedDate.Year == year && x.CreatedDate.Month == month && x.Title == title.Replace("-", " "))
                .FirstOrDefault();

        }
    }
}
