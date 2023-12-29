

using FA.JustBlog.Core.Service.ModelRepository;

namespace FA.JustBlog.Core.Service.UnitOfWork
{
    public interface IUnitOfWork 
    {
       public IPostRepository postRepository { get; set; }
        public ITagRepository tagRepository { get; set; }
        public ICategoryRepository categoryRepository { get; set; }
        public Guid guid { get; set; }
    }
}
