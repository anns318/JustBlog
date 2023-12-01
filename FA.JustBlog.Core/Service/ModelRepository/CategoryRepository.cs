using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.Repository;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Service.ModelRepository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        
        public CategoryRepository(BlogContext ctx) : base(ctx)
        {
        }

        public IEnumerable<Post> PostByCategory(string cateName)
        {
            var Cate = ctx.Categories.Where(x => x.Name == cateName.Replace("-"," ")).FirstOrDefault();
            return Cate?.Post;
        }
    }
}
