using Core;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace BLL;

public class ActorService : GenericRepository<Actor>, IActorService
{
    public ActorService(MovieDbContext context) : base(context)
    {
    }
}
