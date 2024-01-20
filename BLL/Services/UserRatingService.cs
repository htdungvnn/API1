using Core;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace BLL;

public class UserRatingService : GenericRepository<UserRating>, IUserRatingService
{
    public UserRatingService(MovieDbContext context) : base(context)
    {
    }
}
