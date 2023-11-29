namespace AnimalPulse.Core.ValueObjects;

public class Username
{
    public string Value { get; }

    public Username(string value)
    {
        Value = value;
    }

    public static implicit operator Username(string value) => new (value);
    public static implicit operator string(Username username) => username.Value;
}
