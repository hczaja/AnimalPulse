namespace AnimalPulse.Application.DTO;

public class PatientDto : PatientBaseDto
{
    public IEnumerable<TreatmentDto> Treatments { get; set; }
    public DateTimeOffset DateOfRegister { get; set; }
}

public class PatientBaseDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Breed { get; set; }
    public string Gender { get; set; }
    public string Description { get; set; }
    public DateTime DateOfBirth { get; set; }
}
