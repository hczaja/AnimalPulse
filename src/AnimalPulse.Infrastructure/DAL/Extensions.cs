using AnimalPulse.Application.Commands.Handlers;
using AnimalPulse.Core.Repositories;
using AnimalPulse.Infrastructure.DAL.Decorators;
using AnimalPulse.Infrastructure.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AnimalPulse.Infrastructure.DAL;

public static class Extensions
{
    private const string SectionName = "postgres";

    public static IServiceCollection AddPostgres(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var section = configuration.GetSection(SectionName);
        services.Configure<PostgresOptions>(section);

        var options = configuration.GetOptions<PostgresOptions>(SectionName);
        services.AddDbContext<AnimalPulseDbContext>(x => x.UseNpgsql(options.ConnectionString));

        services.AddScoped<IPatientRepository, PostgresPatientRepository>();
        services.AddScoped<IUnitOfWork, PostgresUnitOfWork>();

        services.TryDecorate(typeof(ICommandHandler<>), typeof(UnitOfWorkCommandHandlerDecorator<>));

        services.AddHostedService<DatabaseInitializer>();

        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        return services;
    }
}