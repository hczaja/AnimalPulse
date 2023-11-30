using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using AnimalPulse.Core.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace AnimalPulse.Infrastructure.Exceptions;

internal sealed class ExceptionMiddleware : IMiddleware
{
    private readonly ILogger<ExceptionMiddleware> _logger;

    public ExceptionMiddleware(ILogger<ExceptionMiddleware> logger)
        => _logger = logger;

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception exception)
        {
            _logger.Log(LogLevel.Error, exception.Message);
            await HandleExceptionAsync(exception, context);
        }
    }

    private async Task HandleExceptionAsync(Exception exception, HttpContext context)
    {
        var (statusCode, error) = exception switch
        {
            CustomException => (
                StatusCodes.Status400BadRequest,
                new Error(
                    exception.GetType().Name.Replace("Exception", string.Empty),
                    exception.Message)
            ),
            _ => (
                StatusCodes.Status500InternalServerError,
                new Error(
                    "InternalError",
                    "Internal error occured."
                )
            )
        };

        context.Response.StatusCode = statusCode;
        await context.Response.WriteAsJsonAsync(error);
    }

    private record Error(string Code, string Reason);
}
