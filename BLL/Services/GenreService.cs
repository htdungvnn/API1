using Core;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace BLL;

public class GenreService : GenericRepository<Genre>, IGenreService
{
    public GenreService(MovieDbContext context) : base(context)
    {
    }
}
