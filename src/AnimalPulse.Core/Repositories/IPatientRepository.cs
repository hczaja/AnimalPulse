using AnimalPulse.Core.Enitities;
using AnimalPulse.Core.ValueObjects.Patients;

namespace AnimalPulse.Core.Repositories;

public interface IPatientRepository
{
    Task<Patient> GetPatientAsync(PatientId id);
    Task<IEnumerable<Patient>> GetPatientsAsync();
    Task AddPatientAsync(Patient patient);
}
