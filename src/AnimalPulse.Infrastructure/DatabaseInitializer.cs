using AnimalPulse.Core.Abstractions;
using AnimalPulse.Core.Enitities;
using AnimalPulse.Infrastructure.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AnimalPulse.Infrastructure;

internal sealed class DatabaseInitializer : IHostedService
{
    private readonly IServiceProvider _serviceProvider;

    public DatabaseInitializer(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        using (var scope = _serviceProvider.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<AnimalPulseDbContext>();
            dbContext.Database.Migrate();

            var patients = dbContext.Patients.ToList();
            if (!patients.Any())
            {
                var clock = _serviceProvider.GetRequiredService<IClock>();

                patients = new List<Patient>()
                {
                    Patient.Create(Guid.Parse("00000000-0000-0000-0000-000000000001"), "Rex", "Dog", "Mixed", "Male", DateTime.Parse("2015-04-11"), "", clock.Now()),
                    Patient.Create(Guid.Parse("00000000-0000-0000-0000-000000000002"), "Lucy", "Cat", "Mixed", "Female", DateTime.Parse("2018-12-26"), "", clock.Now())
                };

                dbContext.Patients.AddRange(patients);
                dbContext.SaveChanges();
            }
        }

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
