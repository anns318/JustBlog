using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.Repository;

namespace FA.JustBlog.Core.Service.ModelRepository
{
    public interface IPostRepository : IRepository<Post>
    {
        public Post FindPost(int year,int month, string title);
    }
}
