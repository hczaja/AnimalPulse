using AnimalPulse.Application.DTO;
using AnimalPulse.Application.Queries;
using AnimalPulse.Application.Queries.Handlers;
using AnimalPulse.Core.ValueObjects.Patients;
using Microsoft.EntityFrameworkCore;

namespace AnimalPulse.Infrastructure.DAL.Handlers;

internal sealed class GetPatientHandler : IQueryHandler<GetPatient, PatientDto>
{
    private readonly AnimalPulseDbContext _dbContext;

    public GetPatientHandler(AnimalPulseDbContext dbContext)
        => _dbContext = dbContext;

    public async Task<PatientDto> HandleAsync(GetPatient query)
    {
        var patientId = new PatientId(query.PatientId);
        var patient = await _dbContext.Patients
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == patientId);

        return patient?.AsDto();
    }
}
