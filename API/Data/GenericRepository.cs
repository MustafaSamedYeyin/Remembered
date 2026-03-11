using API.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class GenericRepository<T> where T : BaseEntity
    {
        public LearningDbContext _learningDbContext { get; set; }
        public DbSet<T> _entity { get; set; }
        public GenericRepository(LearningDbContext learningDbContext)
        {
            _learningDbContext = learningDbContext;
            _entity = _learningDbContext.Set<T>();
        }
        public void Post(T entity)
        {
            _entity.Add(entity);
            _learningDbContext.SaveChanges();
        }
        public void Put(T entity)
        {
            _entity.Update(entity);
            _learningDbContext.SaveChanges();
        }
        public void Delete(T entity)
        {
            _entity.Remove(entity);
            _learningDbContext.SaveChanges();
        }
        public T Get(int id)
        {
            return _entity.Find(id);
        }
        public List<T> GetAll()
        {
            return _entity.ToList();

        }
    }
}