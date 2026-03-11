using API.Entities;

namespace API.Data
{
    public class CardRepo : GenericRepository<Card>
    {
        public CardRepo(LearningDbContext learningDbContext) : base(learningDbContext)
        {
        }
    }
}
