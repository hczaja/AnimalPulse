namespace AnimalPulse.Core.ValueObjects.Parameters;

public class Temperature : MedicalParameter<double>
{
    public Temperature(double value) : base(value) { }

    public const string Unit = "°C";

    public static implicit operator Temperature(double value) => new(value);
    public static implicit operator double(Temperature temperature) => temperature.Value;
}
