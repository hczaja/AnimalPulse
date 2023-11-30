using AnimalPulse.Core.Exceptions;

namespace AnimalPulse.Core.ValueObjects.Patients;

public class PatientId
{
    public Guid Value { get; }

    public PatientId(Guid value)
    {
        if (value == Guid.Empty)
            throw new InvalidEntityIdException(value);

        Value = value;
    }

    public static implicit operator PatientId(Guid value) => new(value);
    public static implicit operator Guid(PatientId id) => id.Value;
}
