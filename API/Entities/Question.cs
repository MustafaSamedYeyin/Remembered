using API.Entities.Base;

namespace API.Entities
{
    public class Question : BaseEntity
    {
        public string Text { get; set; }
        public Card Card { get; set; }
    }
}
