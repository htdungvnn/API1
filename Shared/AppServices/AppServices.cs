using BLL;
using Core;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace API;

public static class AppServices
{
    public static void AddAppServices(this IServiceCollection services, IConfiguration config)
    {
        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddDbContext<MovieDbContext>(options => options.UseSqlServer(config.GetConnectionString("SQLConnectionString")));
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddSingleton<ICacheRepository, RedisCacheRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();
    }
}
