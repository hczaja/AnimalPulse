namespace AnimalPulse.Application.DTO;

public class PatientDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTimeOffset DateOfBirth { get; set; }
    public string Description { get; set; }
    public IEnumerable<TreatmentDto> Treatments { get; set; }
}
