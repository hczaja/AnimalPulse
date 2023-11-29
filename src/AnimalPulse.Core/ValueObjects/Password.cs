namespace AnimalPulse.Core.ValueObjects;

public class Password
{
    public string Value { get; }

    public Password(string value)
    {
        Value = value;
    }

    public static implicit operator Password(string value) => new (value);
    public static implicit operator string(Password password) => password.Value;
}
