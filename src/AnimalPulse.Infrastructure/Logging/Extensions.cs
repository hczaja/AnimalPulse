using AnimalPulse.Infrastructure.Logging.Decorators;
using AnimalPulse.Application.Commands;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using AnimalPulse.Application.Commands.Handlers;

namespace AnimalPulse.Infrastructure.Logging;

public static class Extensions
{
    public static IServiceCollection AddSerilog(this IServiceCollection services)
    {
        services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));

        return services;
    }


    public static WebApplicationBuilder UseSerilog(this WebApplicationBuilder builder)
    {
        builder.Host.UseSerilog((context, configuration) => {
            configuration.WriteTo.Console();
        });

        return builder;
    }
}
