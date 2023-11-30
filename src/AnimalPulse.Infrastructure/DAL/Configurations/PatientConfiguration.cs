using AnimalPulse.Core.Enitities;
using AnimalPulse.Core.ValueObjects.Patients;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimalPulse.Infrastructure.DAL.Configurations;

internal sealed class PatientConfiguration
    : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasConversion(id => id.Value, value => new PatientId(value))
            .IsRequired();
        builder.Property(x => x.Name)
            .HasConversion(name => name.Value, value => new PatientName(value))
            .IsRequired();
        builder.Property(x => x.Gender)
            .HasConversion(gender => gender.Value, value => new PatientGender(value))
            .IsRequired();
        builder.Property(x => x.Description)
            .HasConversion(description => description.Value, value => new PatientDescription(value))
            .IsRequired();
        builder.Property(x => x.DateOfBirth)
            .HasConversion(date => date, value => value)
            .IsRequired();
    }
}
