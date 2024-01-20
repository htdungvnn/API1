using Core;

namespace DAL;

public class Actor : BaseEntity
{
    public Guid ActorID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? BirthDate { get; set; }
    public string Bio { get; set; }
    public string ProfileImageURL { get; set; }

    public List<MovieActor> MovieActors { get; set; }
}
