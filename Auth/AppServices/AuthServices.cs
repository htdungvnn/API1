using Auth;
//using BLL;
using Core;
using Microsoft.AspNetCore.Identity;

//using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Auth;

public static class AppServices
{
    public static void AddAuthServices(this IServiceCollection services, IConfiguration config)
    {
        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddDbContext<AuthContext>(options => options.UseSqlServer(config.GetConnectionString("AuthConnectionString")));
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        //services.AddSingleton<ICacheRepository, RedisCacheRepository>();
        //services.AddTransient<IUnitOfWork, UnitOfWork>();
        services.AddAuthorization();
        services.AddIdentityApiEndpoints<IdentityUser>()
        .AddEntityFrameworkStores<AuthContext>();
    }
}
