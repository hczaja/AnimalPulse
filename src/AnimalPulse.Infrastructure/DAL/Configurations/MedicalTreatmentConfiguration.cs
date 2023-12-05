using AnimalPulse.Core.Enitities;
using AnimalPulse.Core.ValueObjects.Patients;
using AnimalPulse.Core.ValueObjects.Treatments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimalPulse.Infrastructure.DAL.Configurations;

public class MedicalTreatmentConfiguration
    : IEntityTypeConfiguration<MedicalTreatment>
{
    public void Configure(EntityTypeBuilder<MedicalTreatment> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasConversion(id => id.Value, value => new TreatmentId(value))
            .IsRequired();
        builder.Property(x => x.PatientId)
            .HasConversion(id => id.Value, value => new PatientId(value))
            .IsRequired();
        builder.Property(x => x.Title)
            .HasConversion(title => title.Value, value => new TreatmentTitle(value))
            .IsRequired();
        builder.Property(x => x.Description)
            .HasConversion(desc => desc.Value, value => new TreatmentDescription(value))
            .IsRequired();
        builder.Property(x => x.Notes)
            .HasConversion(notes => notes.Value, value => new TreatmentNotes(value));
        builder.Property(x => x.StartedAt)
            .HasConversion(date => date, value => value)
            .IsRequired();
    }
}
