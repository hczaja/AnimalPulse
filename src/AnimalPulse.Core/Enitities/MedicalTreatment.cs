using AnimalPulse.Core.ValueObjects.Treatments;

namespace AnimalPulse.Core.Enitities;

public class MedicalTreatment
{
    public TreatmentId Id { get; private set; }
    public TreatmentTitle Title { get; private set; }
    public TreatmentDescription Description { get; private set; }
    public TreatmentNotes Notes { get; private set; }

    public DateTimeOffset StartedAt { get; private set; }

    private readonly List<IMedicalMonitor> _monitors = new();
    public IEnumerable<IMedicalMonitor> Monitors => _monitors;

    public MedicalTreatment(
        TreatmentId id, TreatmentTitle title, 
        TreatmentDescription description, TreatmentNotes notes,
        DateTimeOffset startedAt)
    {
        Id = id;
        Title = title;
        Description = description;
        Notes = notes;
        StartedAt = startedAt;
    }
}
