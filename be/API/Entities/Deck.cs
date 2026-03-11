using API.Entities.Base;

namespace API.Entities
{
    public class Deck : BaseEntity
    {
        public List<Card> Cards { get; set; }
        public Topic Topic { get; set; }
    }
}
