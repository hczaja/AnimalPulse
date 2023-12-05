using AnimalPulse.Application.DTO;

namespace AnimalPulse.Application.Queries;

public record GetPatients : IQuery<IEnumerable<PatientBaseDto>> { }
