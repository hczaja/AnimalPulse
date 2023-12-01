using AnimalPulse.Core.Exceptions;

namespace AnimalPulse.Application.Exceptions;

public class PatientAlreadyExistsException : CustomException
{
    public PatientAlreadyExistsException() 
        : base("Patient already exists.")
    { }
}
