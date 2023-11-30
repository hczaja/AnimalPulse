
namespace AnimalPulse.Core.Exceptions;

public sealed class InvalidTreatmentTitleException : CustomException
{
    public InvalidTreatmentTitleException() 
        : base("Treatment title cannot be empty.")
    { }
}