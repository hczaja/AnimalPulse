using AnimalPulse.Core.ValueObjects.Parameters;

namespace AnimalPulse.Core.Enitities;

public class TemperatureMonitor : MedicalMonitor
{
    public TemperatureMonitor() 
        : base(nameof(TemperatureMonitor), Temperature.Unit)
    { }
}