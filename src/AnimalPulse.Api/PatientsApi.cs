using AnimalPulse.Application.Commands;
using AnimalPulse.Application.Commands.Handlers;
using AnimalPulse.Application.DTO;
using AnimalPulse.Application.Queries;
using AnimalPulse.Application.Queries.Handlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AnimalPulse.Api;

    internal static class PatientsApi
    {
        public static WebApplication UsePatientsApi(this WebApplication app)
        {
            var group = app.MapGroup("patients");

            // group.MapGet("{patientId:guid}", async (Guid patientId, IQueryHandler<GetPatient, PatientDto> handler) => {
                
            //     var patient = await handler.HandleAsync(new GetPatient() { PatientId = patientId });
            //     if (patient is null)
            //         return Results.NotFound();

            //     return Results.Ok(patient);
            // });
            // //.RequireAuthorization();

            group.MapGet("/", async (IQueryHandler<GetPatients, IEnumerable<PatientBaseDto>> handler) => {
                var patients = await handler.HandleAsync(new GetPatients());
                if (patients is null || !patients.Any())
                    return Results.NotFound();
                
                return Results.Ok(patients);
            });
            //.RequireAuthorization();

            // group.MapPost("", async ([FromBody]AddPatient command, ICommandHandler<AddPatient> handler) => {
                
            //     command = command with { PatientId = Guid.NewGuid(), DateOfRegister = DateTime.Today };
            //     await handler.HandleAsync(command);

            //     return Results.CreatedAtRoute(command.PatientId.ToString());
            // });
            //.RequireAuthorization();

            return app;
        } 
    }
