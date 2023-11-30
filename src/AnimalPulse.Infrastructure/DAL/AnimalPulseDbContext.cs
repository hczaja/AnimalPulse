using AnimalPulse.Application.DTO;
using AnimalPulse.Application.Queries;
using AnimalPulse.Core.Enitities;
using Microsoft.EntityFrameworkCore;

namespace AnimalPulse.Infrastructure.DAL;

internal sealed class AnimalPulseDbContext : DbContext
{
    public DbSet<MedicalTreatment> Treatments { get; set; }
    public DbSet<Patient> Patients { get; set; }

    public AnimalPulseDbContext(DbContextOptions<AnimalPulseDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
