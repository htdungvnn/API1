namespace Core;

public abstract class BaseEntity
{
    //public Guid Id { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
