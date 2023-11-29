namespace AnimalPulse.Core.ValueObjects;

public class UserId
{
    public Guid Value { get; }

    public UserId(Guid value)
    {
        Value = value;
    }

    public static implicit operator UserId(Guid value) => new (value);
    public static implicit operator Guid(UserId id) => id.Value;
}
