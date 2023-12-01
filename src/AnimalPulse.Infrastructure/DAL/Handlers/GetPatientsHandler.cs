using AnimalPulse.Application.DTO;
using AnimalPulse.Application.Queries;
using AnimalPulse.Application.Queries.Handlers;
using Microsoft.EntityFrameworkCore;

namespace AnimalPulse.Infrastructure.DAL.Handlers;

internal sealed class GetPatientsHandler : IQueryHandler<GetPatients, IEnumerable<PatientBaseDto>>
{
    private readonly AnimalPulseDbContext _dbContext;

    public GetPatientsHandler(AnimalPulseDbContext dbContext)
        => _dbContext = dbContext;

    public async Task<IEnumerable<PatientBaseDto>> HandleAsync(GetPatients query)
        => await _dbContext.Patients
            .AsNoTracking()
            .Select(x => x.AsBaseDto())
            .ToListAsync();
}
