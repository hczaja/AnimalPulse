namespace AnimalPulse.Application.Commands;

public record AddPatient(
    Guid PatientId, 
    string Name,
    string Type,
    string Breed,
    string Gender, 
    DateTime DateOfBirth, 
    string Description, 
    DateTimeOffset DateOfRegister) 
        : ICommand { }
