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
        public IEnumerable<Post> GetPostByTagName(string name)
        {
            var Tag = ctx.Tags.Where(t => t.Name == name.Replace("-"," ")).FirstOrDefault();
            if(Tag == null)
            {
                return null;
            }
            List<Post> posts = new List<Post>();
            foreach (var post in Tag.PostTags)
            {
                posts.Add(post.Post);
            }

            return posts;
        }
        public IEnumerable<PostTagCountVM> getPopularTag()
        {
            var query = (from t in ctx.Tags
                         join x in
                             (from pt in ctx.PostTag
                              group pt by pt.TagId into g
                              select new { TagId = g.Key, CountPost = g.Count() }) on t.Id equals x.TagId into temp
                         from d in temp.DefaultIfEmpty()
                         select new PostTagCountVM
                         {
                             TagName = t.Name,
                             CountPost = d.CountPost == null ? 0 : d.CountPost
                         }).OrderByDescending(x => x.CountPost).Take(10);



            return query;

        }
    }
}
