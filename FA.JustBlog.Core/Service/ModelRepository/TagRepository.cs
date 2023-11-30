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

        public List<PostTagCountVM> getPopularTag()
        {
            var query = from t in ctx.Tags
                        join x in
                            (from pt in ctx.PostTag
                             group pt by pt.TagId into g
                             select new { TagId = g.Key, CountPost = g.Count() }) on t.Id equals x.TagId into temp
                        from x in temp.DefaultIfEmpty()
                        select new 
                        {
                            TagName = t.Name,
                            CountPost = x != null ? x.CountPost : 0
                        };

            List<PostTagCountVM> resultList = query.Select(x => new PostTagCountVM { CountPost = x.CountPost, TagName = x.TagName}).ToList();

            return resultList;

        }
    }
}
