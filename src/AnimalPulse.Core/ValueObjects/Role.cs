namespace AnimalPulse.Core.ValueObjects;

public class Role
{
    public string Value { get; }

    public Role(string value)
    {
        Value = value;
    }

    public static implicit operator Role(string value) => new (value);
    public static implicit operator string(Role role) => role.Value;
}
