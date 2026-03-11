using API.Entities;

namespace API.Data
{
    public class QuestionRepo : GenericRepository<Question>
    {
        public QuestionRepo(LearningDbContext learningDbContext) : base(learningDbContext)
        {
        }
    }
}
