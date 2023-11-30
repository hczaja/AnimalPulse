namespace AnimalPulse.Core.ValueObjects.Patients;

public class PatientDescription
{
    public string Value { get; }

    public PatientDescription(string value)
    {
        Value = value;
    }

    public static implicit operator PatientDescription(string value) => new(value);
    public static implicit operator string(PatientDescription description) => description.Value;
}
