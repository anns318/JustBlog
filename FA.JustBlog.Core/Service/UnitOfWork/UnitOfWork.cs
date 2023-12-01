using FA.JustBlog.Core.Service.ModelRepository;

namespace FA.JustBlog.Core.Service.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        
        public UnitOfWork(IPostRepository postRepository,ITagRepository tagRepository,ICategoryRepository categoryRepository)
        {
            this.tagRepository = tagRepository;
            this.postRepository = postRepository;
            this.categoryRepository = categoryRepository;
        }

        public IPostRepository postRepository { get;set; }
        public ITagRepository tagRepository { get;set; }
        public ICategoryRepository categoryRepository { get ; set ; }
    }
}
