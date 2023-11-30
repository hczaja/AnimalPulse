using AnimalPulse.Core.ValueObjects.Parameters;

namespace AnimalPulse.Core.Enitities;

public class TemperatureMonitor : MedicalMonitor<double>, IMedicalMonitor
{
    public TemperatureMonitor() 
        : base(nameof(TemperatureMonitor), Temperature.Unit)
    { }
}