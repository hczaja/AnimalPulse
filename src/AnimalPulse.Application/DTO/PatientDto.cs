namespace AnimalPulse.Application.DTO;

public class PatientDto : PatientBaseDto
{
    public IEnumerable<TreatmentDto> Treatments { get; set; }
}

public class PatientBaseDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Breed { get; set; }
    public string Gender { get; set; }
    public string Description { get; set; }
    public DateTimeOffset DateOfBirth { get; set; }
}
