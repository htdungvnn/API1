namespace DAL;

public class Actor
{
    public Guid ActorID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? BirthDate { get; set; }
    public string Bio { get; set; }
    public string ProfileImageURL { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public List<MovieActor> MovieActors { get; set; }
}
