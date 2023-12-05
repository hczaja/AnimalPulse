using Microsoft.Extensions.DependencyInjection;

namespace AnimalPulse.Infrastructure.DAL;

public static class Extensions
{
    public static IServiceCollection AddPostgres(
        this IServiceCollection services)
    {
        services.AddHostedService<DatabaseInitializer>();

        return services;
    }
}