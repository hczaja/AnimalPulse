using AnimalPulse.Core.Enitities;

namespace AnimalPulse.Application.DTO;

public class MonitorDto
{
    public string Name { get; set; }
    public string Unit { get; set; }
    public IEnumerable<MeasurementDto> Values { get; set; }
}
