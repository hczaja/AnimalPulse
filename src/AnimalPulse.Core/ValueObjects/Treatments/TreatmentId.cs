using AnimalPulse.Core.Exceptions;

namespace AnimalPulse.Core.ValueObjects.Treatments;

public class TreatmentId
{
    public Guid Value { get; }

    public TreatmentId(Guid value)
    {
        if (value == Guid.Empty)
            throw new InvalidEntityIdException(value);

        Value = value;
    }

    public static implicit operator TreatmentId(Guid value) => new(value);
    public static implicit operator Guid(TreatmentId id) => id.Value;
}
