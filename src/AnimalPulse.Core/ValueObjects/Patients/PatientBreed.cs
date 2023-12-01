namespace AnimalPulse.Core.ValueObjects.Patients;

public class PatientBreed
{
    public string Value { get; }

    public PatientBreed(string value)
    {
        Value = value;
    }

    public static implicit operator PatientBreed(string value) => new(value);
    public static implicit operator string(PatientBreed breed) => breed.Value;
}
