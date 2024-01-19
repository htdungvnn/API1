namespace DAL;

public class MovieActor
{
    public Guid MovieActorID { get; set; }
    public Guid MovieID { get; set; }
    public Guid ActorID { get; set; }
    public string Role { get; set; }

    public Movie Movie { get; set; }
    public Actor Actor { get; set; }
}
