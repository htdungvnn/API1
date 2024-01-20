using Core;

namespace DAL;

public class Review : BaseEntity
{
    public Guid ReviewID { get; set; }
    public Guid MovieID { get; set; }
    public Guid UserID { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    public Movie Movie { get; set; }
    public User User { get; set; }
}
