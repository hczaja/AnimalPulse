namespace AnimalPulse.Core.ValueObjects.Patients;

public class PatientGender
{
    public string Value { get; }

    public PatientGender(string value)
    {
        Value = value;
    }

    public static implicit operator PatientGender(string value) => new(value);
    public static implicit operator string(PatientGender gender) => gender.Value;
}
