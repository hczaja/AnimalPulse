using AnimalPulse.Application.Queries.Handlers;
using AnimalPulse.Core.Abstractions;
using AnimalPulse.Infrastructure.DAL;
using AnimalPulse.Infrastructure.Exceptions;
using AnimalPulse.Infrastructure.Logging;
using AnimalPulse.Infrastructure.Time;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AnimalPulse.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<ExceptionMiddleware>();
        services.AddSerilog();

        services.AddHttpContextAccessor();

        services.AddSingleton<IClock, Clock>();
        services.AddPostgres(configuration);

        var applicationAssembly = typeof(Clock).Assembly;
        
        services.Scan(s => s.FromAssemblies(applicationAssembly)
            .AddClasses(c => c.AssignableTo(typeof(IQueryHandler<,>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());

        return services;
    }

    public static WebApplication UseInfrastructure(this WebApplication app)
    {
        app.UseMiddleware<ExceptionMiddleware>();

        return app;
    }

    public static T GetOptions<T>(this IConfiguration configuration, string sectionName) where T : class, new()
    {
        var options = new T();
        
        var section = configuration.GetSection(sectionName);
        section.Bind(options);

        return options;
    }
}
