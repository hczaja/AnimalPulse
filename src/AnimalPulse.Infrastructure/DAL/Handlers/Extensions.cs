using AnimalPulse.Application.DTO;
using AnimalPulse.Core.Enitities;

namespace AnimalPulse.Infrastructure.DAL.Handlers;

internal static class Extensions
{
    public static PatientBaseDto AsBaseDto(this Patient patient)
        => new()
        {
            Id = patient.Id,
            Name = patient.Name,
            Type = patient.Type,
            Breed = patient.Breed,
            Gender = patient.Gender,
            DateOfBirth = patient.DateOfBirth,
            Description = patient.Description,
        };

    public static PatientDto AsDto(this Patient patient)
        => new()
        {
            Id = patient.Id,
            Name = patient.Name,
            Type = patient.Type,
            Breed = patient.Breed,
            Gender = patient.Gender,
            DateOfBirth = patient.DateOfBirth,
            DateOfRegister = patient.DateOfRegister,
            Description = patient.Description,
            Treatments = patient.Treatments.Select(t => t.AsDto())
        };

    public static TreatmentDto AsDto(this MedicalTreatment treatment)
        => new ()
        {
            Id = treatment.Id,
            PatientId = treatment.PatientId,
            Title = treatment.Title,
            Description = treatment.Description,
            Notes = treatment.Notes,
            StartedAt = treatment.StartedAt
            //Monitors = treatment.Monitors.Select(m => m.AsDto())
        };

    public static MonitorDto AsDto(this MedicalMonitor monitor)
        => new ()
        {
            Name = monitor.Name,
            Unit = monitor.Unit,
            Values = monitor.Values.Select(v => v.AsDto())
        };

    public static MeasurementDto AsDto(this Measurement measurement)
        => new()
        {
            TimeOfMeasure = measurement.MeasuredAt,
            Value = measurement.Value
        };
}
