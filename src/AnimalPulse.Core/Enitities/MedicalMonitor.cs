using AnimalPulse.Core.ValueObjects.Monitors;

namespace AnimalPulse.Core.Enitities;

public abstract class MedicalMonitor<T> where T : struct 
{
    public MedicalMonitorName Name { get; private set; }
    public MedicalMonitorUnit Unit { get; private set; }

    private readonly List<T> _values = new();
    public IEnumerable<T> Values => _values;

    protected MedicalMonitor(MedicalMonitorName name, MedicalMonitorUnit unit)
    {
        Name = name;
        Unit = unit;   
    }   
}
