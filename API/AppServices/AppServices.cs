using Core;

namespace API;

public static class AppServices
{
    public static void AddAppServices(this IServiceCollection services)
    {

        services.AddSingleton<ICacheRepository, RedisCacheRepository>();

    }
}
