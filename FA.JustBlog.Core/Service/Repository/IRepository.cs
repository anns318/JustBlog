namespace FA.JustBlog.Core.Service.Repository
{
    public interface IRepository<T> where T : class 
    {
        public T GetById(int Id);
        public List<T> GetAll();
        public List<T> Find(Func<T,bool> Predicate);
        public void Edit(T entity);
        public void Delete(int Id);
        public void Add(T entity);
    }
}
