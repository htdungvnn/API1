using Core;

namespace DAL;

public class User : BaseEntity
{
    public Guid UserID { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime RegistrationDate { get; set; }

    public List<Review> Reviews { get; set; }
    public List<UserRating> UserRatings { get; set; }
}
