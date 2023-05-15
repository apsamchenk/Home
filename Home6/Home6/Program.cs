using System;

namespace Home6 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Therapist therapist = new Therapist("Sarah Smith", 7);
            Dentist dentist = new Dentist("Nicky Adamson", 12);
            Ophthalmologist ophthalmologist = new Ophthalmologist("Martin Brown", 3);

            Patient patient1 = new Patient("Andrew Parson", IllnessType.Other, 26);
            Patient patient2 = new Patient("Danny Evans", IllnessType.Teeth, 37);
            Patient patient3 = new Patient("Freddy Lewis", IllnessType.Eyes, 18);

            Clinic clinic = new Clinic("Good Clinic", therapist, dentist, ophthalmologist);

            clinic.SendPatientToDoctor(patient1);
            clinic.SendPatientToDoctor(patient2);
            clinic.SendPatientToDoctor(patient3);
        }
    }
}