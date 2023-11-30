using AnimalPulse.Core.Abstractions;

namespace AnimalPulse.Infrastructure.Time;

public class Clock : IClock
{
    public DateTimeOffset Now() => DateTimeOffset.Now;
}
