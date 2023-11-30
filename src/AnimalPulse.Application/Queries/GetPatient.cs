using AnimalPulse.Application.DTO;

namespace AnimalPulse.Application.Queries;

public class GetPatient : IQuery<PatientDto>
{
    public Guid PatientId { get; set; }
}
