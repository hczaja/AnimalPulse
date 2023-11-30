namespace AnimalPulse.Core.ValueObjects.Treatments;

public class TreatmentDescription
{
    public string Value { get; }

    public TreatmentDescription(string value)
    {
        Value = value;
    }

    public static implicit operator TreatmentDescription(string value) => new(value);
    public static implicit operator string(TreatmentDescription description) => description.Value;
}
