using Core;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace BLL;

public class UserService : GenericRepository<User>, IUserService
{
    public UserService(MovieDbContext context) : base(context)
    {
    }
}
