using AnimalPulse.Application.DTO;

namespace AnimalPulse.Application.Queries;

public record GetTreatment : IQuery<TreatmentDto>
{
    public Guid TreatmentId { get; set; }
}

