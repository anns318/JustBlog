using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.Repository;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Service.ModelRepository
{
    public class TagRepository :  Repository<Tag>,ITagRepository
    {
        public TagRepository(BlogContext ctx) : base(ctx)
        {
        }

        //public List<Tag> getPopularTag()
        //{
        //    var list = from x in ctx.Tags.Include(x=>x.PostTags).ToList()
        //               group x by x.Id into g
                       

        //}
    }
}
