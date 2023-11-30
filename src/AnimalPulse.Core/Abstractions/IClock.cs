namespace AnimalPulse.Core.Abstractions;

public interface IClock
{
    DateTimeOffset Now();
}
