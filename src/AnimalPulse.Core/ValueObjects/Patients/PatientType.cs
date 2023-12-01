namespace AnimalPulse.Core.ValueObjects.Patients;

public class PatientType
{
    public string Value { get; }

    public PatientType(string value)
    {
        Value = value;
    }

    public static implicit operator PatientType(string value) => new(value);
    public static implicit operator string(PatientType type) => type.Value;
}
