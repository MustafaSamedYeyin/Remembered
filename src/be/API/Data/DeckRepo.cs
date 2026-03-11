using API.Entities;

namespace API.Data
{
    public class DeckRepo : GenericRepository<Deck>
    {
        public DeckRepo(LearningDbContext learningDbContext) : base(learningDbContext)
        {
        }
    }
}
