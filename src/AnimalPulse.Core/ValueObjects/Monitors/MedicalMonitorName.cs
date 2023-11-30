namespace AnimalPulse.Core.ValueObjects.Monitors;

public class MedicalMonitorName
{
    public string Value { get; }

    public MedicalMonitorName(string value)
    {
        Value = value;
    }

    public static implicit operator MedicalMonitorName(string value) => new(value);
    public static implicit operator string(MedicalMonitorName monitorName) => monitorName.Value;
}
