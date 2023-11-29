
using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Core.Service.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BlogContext ctx;
        public Repository(BlogContext ctx)
        {
            this.ctx = ctx;
        }
        public void Add(T entity)
        {
            ctx.Set<T>().Add(entity);
            ctx.SaveChanges();
        }

        public void Delete(int Id)
        {
            var obj = ctx.Set<T>().Find(Id);
            if (obj != null)
            {
                ctx.Set<T>().Remove(obj);
                ctx.SaveChanges();
            }
        }

        public void Edit(T entity)
        {

            ctx.Set<T>().Update(entity);
            ctx.SaveChanges();
            
        }

        public List<T> Find(Func<T, bool> Predicate)
        {
            return ctx.Set<T>().Where(Predicate).ToList();
        }

        public List<T> GetAll()
        {
            return ctx.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            return ctx.Set<T>().Find(Id);
        }
    }
}
