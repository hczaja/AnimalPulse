using System.Diagnostics;
using AnimalPulse.Application.Commands;
using AnimalPulse.Application.Commands.Handlers;
using Microsoft.Extensions.Logging;

namespace AnimalPulse.Infrastructure.Logging.Decorators;

internal sealed class LoggingCommandHandlerDecorator<TCommand>
    : ICommandHandler<TCommand> where TCommand : class, ICommand
{
    private readonly ICommandHandler<TCommand> _handler;
    private readonly ILogger<ICommandHandler<TCommand>> _logger;

    public LoggingCommandHandlerDecorator(
        ICommandHandler<TCommand> handler,
        ILogger<ICommandHandler<TCommand>> logger)
    {
        _handler = handler;
        _logger = logger;
    }

    public async Task HandleAsync(TCommand command)
    {
        var name = typeof(TCommand).Name;
        var sw = new Stopwatch();

        _logger.LogInformation("Started handling a command: {CommandName}", name);
        sw.Start();

        await _handler.HandleAsync(command);

        sw.Stop();
        _logger.LogInformation("Completed handling a command: {CommandName} in, {Elapsed}", name, sw.Elapsed);
    }
}
