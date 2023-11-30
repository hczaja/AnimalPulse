namespace AnimalPulse.Application.DTO;

public class TreatmentDto
{
    public Guid Id { get; set; }
    public Guid PatientId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Notes { get; set; }
    public DateTimeOffset StartedAt { get; set; }
    public IEnumerable<MonitorDto> Monitors { get; set; }
}
