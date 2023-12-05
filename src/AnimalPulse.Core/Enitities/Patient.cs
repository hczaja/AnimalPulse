using AnimalPulse.Core.ValueObjects.Patients;

namespace AnimalPulse.Core.Enitities
{
    public class Patient
    {
        public PatientId Id { get; private set; }
        public PatientName Name { get; private set; }
        public PatientType Type { get; private set; }
        public PatientBreed Breed { get; private set; }
        public PatientGender Gender { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public PatientDescription Description { get; private set; }
        public DateTimeOffset DateOfRegister { get; private set; }

        private readonly List<MedicalTreatment> _treatments = new();
        public IEnumerable<MedicalTreatment> Treatments => _treatments;

        public static Patient Create(PatientId id, PatientName name, PatientType type, PatientBreed breed,
            PatientGender gender, DateTime dateOfBirth, PatientDescription description, DateTimeOffset dateOfRegister)
                => new Patient(id, name, type, breed, gender, dateOfBirth, description, dateOfRegister);
        private Patient(PatientId id, PatientName name, PatientType type, PatientBreed breed,
            PatientGender gender, DateTime dateOfBirth, PatientDescription description, DateTimeOffset dateOfRegister)
                => (Id, Name, Type, Breed, Gender, DateOfBirth, Description, DateOfRegister) 
                    = (id, name, type, breed, gender, dateOfBirth, description, dateOfRegister);
    }
}