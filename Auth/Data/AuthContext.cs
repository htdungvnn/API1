using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Auth;

public class AuthContext : IdentityDbContext
{
    public AuthContext(DbContextOptions<AuthContext> option) : base(option)
    {

    }
}
