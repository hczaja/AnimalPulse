namespace AnimalPulse.Core.Enitities;

public class Measurement
{
    public DateTimeOffset MeasuredAt { get; private set; }
    public double Value { get; private set; }

    public Measurement(DateTimeOffset measuredAt, double value)
        => (MeasuredAt, Value) = (measuredAt, value);
}
