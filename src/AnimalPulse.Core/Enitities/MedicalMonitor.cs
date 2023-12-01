using AnimalPulse.Core.ValueObjects.Monitors;

namespace AnimalPulse.Core.Enitities;

public abstract class MedicalMonitor 
{
    public MedicalMonitorName Name { get; private set; }
    public MedicalMonitorUnit Unit { get; private set; }

    private readonly List<Measurement> _values = new();
    public IEnumerable<Measurement> Values => _values;

    protected MedicalMonitor(MedicalMonitorName name, MedicalMonitorUnit unit)
    {
        Name = name;
        Unit = unit;   
    }   
}
