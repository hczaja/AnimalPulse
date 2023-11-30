using AnimalPulse.Core.Exceptions;

namespace AnimalPulse.Core.ValueObjects.Treatments;

public class TreatmentTitle
{
    public string Value { get; }

    public TreatmentTitle(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new InvalidTreatmentTitleException();

        Value = value;
    }

    public static implicit operator TreatmentTitle(string value) => new(value);
    public static implicit operator string(TreatmentTitle title) => title.Value;
}

