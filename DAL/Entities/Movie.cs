using Core;

namespace DAL;

public class Movie : BaseEntity
{
    public Guid MovieID { get; set; }
    public string Title { get; set; }
    public int? ReleaseYear { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
    public decimal Rating { get; set; }
    public string Description { get; set; }
    public string PosterURL { get; set; }
    public string TrailerURL { get; set; }

    public List<MovieActor> MovieActors { get; set; }
    public List<MovieGenre> MovieGenres { get; set; }
    public List<Review> Reviews { get; set; }
    public List<UserRating> UserRatings { get; set; }
}
