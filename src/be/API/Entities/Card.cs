using API.Entities.Base;

namespace API.Entities
{
    public class Card : BaseEntity
    {
        public Question? Question { get; set; }
        public string FronText { get; set; }
        public string BackText { get; set; }
        public Topic Topic { get; set; }
    }
}
