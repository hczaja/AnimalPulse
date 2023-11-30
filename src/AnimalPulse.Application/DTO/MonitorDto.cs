namespace AnimalPulse.Application.DTO;

public class MonitorDto
{
    public string Name { get; set; }
    public string Unit { get; set; }
    public IEnumerable<double> Values { get; set; }
}
