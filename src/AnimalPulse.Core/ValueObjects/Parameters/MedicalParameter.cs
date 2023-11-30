namespace AnimalPulse.Core.ValueObjects.Parameters;

public abstract class MedicalParameter<T> where T : struct
{
    public T Value { get; }

    public MedicalParameter(T value)
    {
        Value = value;
    }
}
