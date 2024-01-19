namespace DAL;

public class MovieGenre
{
    public Guid MovieGenreID { get; set; }
    public Guid MovieID { get; set; }
    public Guid GenreID { get; set; }

    public Movie Movie { get; set; }
    public Genre Genre { get; set; }
}
