using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.Repository;

namespace FA.JustBlog.Core.Service.ModelRepository
{
    public class PostRepository : Repository<Post>,IPostRepository
    {

        public PostRepository(BlogContext ctx) : base(ctx)
        {

        }
    }
}
