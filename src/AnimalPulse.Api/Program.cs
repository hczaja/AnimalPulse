using AnimalPulse.Api;
using AnimalPulse.Core;
using AnimalPulse.Application;
using AnimalPulse.Infrastructure;
using AnimalPulse.Infrastructure.Logging;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddCore()
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

builder.UseSerilog();

var app = builder.Build();

app.UseInfrastructure();
app.UseTreatmentsApi();

app.Run();
