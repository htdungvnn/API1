using Core;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace BLL;

public class MovieGenreService : GenericRepository<MovieGenre>, IMovieGenreService
{
    public MovieGenreService(MovieDbContext context) : base(context)
    {
    }
}
