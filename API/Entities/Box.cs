using API.Entities.Base;
using API.Enums;

namespace API.Entities
{
    public class Box : BaseEntity
    {
        public List<Deck> Decks { get; set; }
        public BoxTypeEnum Type { get; set; }
    }
}
