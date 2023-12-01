using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.Repository;

namespace FA.JustBlog.Core.Service.ModelRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public IEnumerable<Post> PostByCategory(string cateName);
    }
}
