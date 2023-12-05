using AnimalPulse.Core.Enitities;
using AnimalPulse.Core.Repositories;
using AnimalPulse.Core.ValueObjects.Patients;
using Microsoft.EntityFrameworkCore;

namespace AnimalPulse.Infrastructure.DAL.Repositories;

internal sealed class PostgresPatientRepository : IPatientRepository
{
    private readonly DbSet<Patient> _patients;

    public PostgresPatientRepository(AnimalPulseDbContext dbContext)
    {
        _patients = dbContext.Patients;
    }

    public async Task AddPatientAsync(Patient patient)
        => await _patients.AddAsync(patient);

    public Task<Patient> GetPatientAsync(PatientId id)
        => _patients.SingleOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<Patient>> GetPatientsAsync()
        => await _patients.ToListAsync();
}