using Core;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace BLL;

public class MovieActorService : GenericRepository<MovieActor>, IMovieActorService
{
    public MovieActorService(MovieDbContext context) : base(context)
    {
    }
}
