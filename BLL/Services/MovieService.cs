using Core;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace BLL;

public class MovieService : GenericRepository<Movie>, IMovieService
{
    public MovieService(MovieDbContext context) : base(context)
    {
    }
}
