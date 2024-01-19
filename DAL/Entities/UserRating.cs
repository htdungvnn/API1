using Core;

namespace DAL;

public class UserRating : BaseEntity
{
    public Guid UserRatingID { get; set; }
    public Guid MovieID { get; set; }
    public Guid UserID { get; set; }
    public int Rating { get; set; }

    public Movie Movie { get; set; }
    public User User { get; set; }
}
