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
        public async Task<T> Post(T entity)
        {
            var result = await _entity.AddAsync(entity);
            await _learningDbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<T> Put(T entity)
        {
            var result = _entity.Update(entity);
            await _learningDbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task Delete(T entity)
        {
            _entity.Remove(entity);
            await _learningDbContext.SaveChangesAsync();
        }
        public async Task<T> Get(Guid id)
        {
            return await _entity.AsNoTracking().FirstOrDefaultAsync(i=> i.Id == id);
        }
        public async Task<List<T>> GetAll()
        {
            return await _entity.AsNoTracking().ToListAsync();

        }
    }
}