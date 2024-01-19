using Core;

namespace DAL;

public class Genre : BaseEntity
{
    public Guid GenreID { get; set; }
    public string GenreName { get; set; }

    public List<MovieGenre> MovieGenres { get; set; }
}
