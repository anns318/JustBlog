using FA.JustBlog.Core.Service.ModelRepository;

namespace FA.JustBlog.Core.Service.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public Guid guid { get; set; }
        public UnitOfWork(IPostRepository postRepository,ITagRepository tagRepository,ICategoryRepository categoryRepository)
        {
            guid = Guid.NewGuid();
            this.tagRepository = tagRepository;
            this.postRepository = postRepository;
            this.categoryRepository = categoryRepository;
        }

        public IPostRepository postRepository { get;set; }
        public ITagRepository tagRepository { get;set; }
        public ICategoryRepository categoryRepository { get ; set ; }
    }
}
