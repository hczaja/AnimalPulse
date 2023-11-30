using AnimalPulse.Core.ValueObjects.Patients;

namespace AnimalPulse.Core.Enitities
{
    public class Patient
    {
        public PatientId Id { get; private set; }
        public PatientName Name { get; private set; }
        public PatientGender Gender { get; private set; }
        public DateTimeOffset DateOfBirth { get; private set; }
        public PatientDescription Description { get; private set; }
        
        private readonly List<MedicalTreatment> _treatments = new();
        public IEnumerable<MedicalTreatment> Treatments => _treatments;
    }
}