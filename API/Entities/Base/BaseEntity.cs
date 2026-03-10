namespace API.Entities.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.CreateVersion7;
    }
}
