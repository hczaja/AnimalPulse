namespace AnimalPulse.Core.ValueObjects.Patients;

public class PatientName
{
    public string Value { get; }

    public PatientName(string value)
    {
        Value = value;
    }

    public static implicit operator PatientName(string value) => new(value);
    public static implicit operator string(PatientName name) => name.Value;
}
