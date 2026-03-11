using API.Entities;

namespace API.Data
{
    public class TopicRepo : GenericRepository<Topic>
    {
        public TopicRepo(LearningDbContext learningDbContext) : base(learningDbContext)
        {
        }
    }
}
