using API.Entities;

namespace API.Data
{
    public class BoxRepo : GenericRepository<Box>
    {
        public BoxRepo(LearningDbContext learningDbContext) : base(learningDbContext)
        {
        }
    }
}
