using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    internal class Clinic
    {
        public string Title { get; set; }

        public Therapist Therapist { get; set; }

        public Dentist Dentist { get; set; }

        public Ophthalmologist Ophthalmologist { get; set; }

        public Clinic(string title, Therapist therapist, Dentist dentist, Ophthalmologist ophthalmologist)
        {
            Title = title;
            Therapist = therapist;
            Dentist = dentist;
            Ophthalmologist = ophthalmologist;
        }

        public void SendPatientToDoctor(Patient patient)
        {
            Console.Write($"\nPatient {patient.Name} is gonna to ");

            switch (patient.IlnessType)
            {
                case IllnessType.Other:
                    Therapist.Treat();
                    Console.WriteLine($"\nDoctor name: {Therapist.Name} - therapist");
                    break;
                case IllnessType.Eyes:
                    Ophthalmologist.Treat();
                    Console.WriteLine($"\nDoctor name: {Ophthalmologist.Name} - ophthalmologist");
                    break;
                case IllnessType.Teeth:
                    Dentist.Treat();
                    Console.WriteLine($"\nDoctor name: {Dentist.Name} - dentist");
                    break;
            }
        }   
    }
}
