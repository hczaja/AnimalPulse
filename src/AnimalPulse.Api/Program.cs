using AnimalPulse.Api;
using AnimalPulse.Application;
using AnimalPulse.Infrastructure;
using AnimalPulse.Infrastructure.Logging;
using AnimalPulse.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddCore()
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

builder.UseSerilog();

var app = builder.Build();

app.UseInfrastructure();
app.UsePatientsApi();

app.Run();
