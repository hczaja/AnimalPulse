namespace AnimalPulse.Core.ValueObjects.Treatments;

public class TreatmentNotes
{
    public string Value { get; }

    public TreatmentNotes(string value)
    {
        Value = value;
    }

    public static implicit operator TreatmentNotes(string value) => new(value);
    public static implicit operator string(TreatmentNotes notes) => notes.Value;
}
