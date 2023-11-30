using AnimalPulse.Application.DTO;
using AnimalPulse.Core.Enitities;

namespace AnimalPulse.Infrastructure.DAL.Handlers;

internal static class Extensions
{
    public static PatientDto AsDto(this Patient patient)
        => new()
        {
            Id = patient.Id,
            Name = patient.Name,
            DateOfBirth = patient.DateOfBirth,
            Description = patient.Description,
            Treatments = patient.Treatments.Select(t => new TreatmentDto()
            {
                Id = t.Id,
                PatientId = t.PatientId,
                Title = t.Title,
                Description = t.Description,
                Notes = t.Notes,
                StartedAt = t.StartedAt,
                Monitors = t.Monitors.Select(m => new MonitorDto()
                {
                    //Name = m.Na
                })
            })

        };
}
