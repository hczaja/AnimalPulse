namespace AnimalPulse.Core.ValueObjects.Monitors;

public class MedicalMonitorUnit
{
    public string Value { get; }

    public MedicalMonitorUnit(string value)
    {
        Value = value;
    }

    public static implicit operator MedicalMonitorUnit(string value) => new(value);
    public static implicit operator string(MedicalMonitorUnit monitorUnit) => monitorUnit.Value;
}
