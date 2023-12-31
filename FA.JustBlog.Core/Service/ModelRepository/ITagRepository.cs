﻿using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.Repository;

namespace FA.JustBlog.Core.Service.ModelRepository
{
    public interface ITagRepository : IRepository<Tag>
    {
        public IEnumerable<PostTagCountVM> getPopularTag();
        public IEnumerable<Post> GetPostByTagName(string name);
    }
}
