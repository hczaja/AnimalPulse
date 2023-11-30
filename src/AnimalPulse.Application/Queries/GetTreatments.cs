using AnimalPulse.Application.DTO;

namespace AnimalPulse.Application.Queries;

public record GetTreatments : IQuery<IEnumerable<TreatmentDto>>
{
    public Guid PatientId { get; }
}
