
using AnimalPulse.Application.Exceptions;
using AnimalPulse.Core.Enitities;
using AnimalPulse.Core.Repositories;
using AnimalPulse.Core.ValueObjects.Patients;

namespace AnimalPulse.Application.Commands.Handlers;

public class AddPatientHandler : ICommandHandler<AddPatient>
{
    private readonly IPatientRepository _patientRepository;

    public AddPatientHandler(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }

    public async Task HandleAsync(AddPatient command)
    {
        var id = new PatientId(command.PatientId);

        if (_patientRepository.GetPatientAsync(id) is not null)
            throw new PatientAlreadyExistsException();

        var name = new PatientName(command.Name);
        var type = new PatientType(command.Type);
        var breed = new PatientBreed(command.Type);
        var gender = new PatientGender(command.Gender);
        var birthDate = command.DateOfBirth;
        var description = new PatientDescription(command.Description);
        var registerData = command.DateOfRegister;

        var patient = Patient.Create(id, name, type, breed, gender, birthDate, description, registerData);

        await _patientRepository.AddPatientAsync(patient);
    }
}
