using Home5;
using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name arrays for all 3 groups
            string[] names1 = { "John", "Alex", "Oliver", "Harry", "Mary" };
            string[] names2 = { "Jacob", "Thomas", "Oscar", "Gimmy", "Charley" };
            string[] names3 = { "George", "Andrew", "Bernard", "Carl", "Daniel" };

            //Groups filling
            StudentsCreator studentsCreator1 = new StudentsCreator();
            Student[] arrayOfStudents1 = studentsCreator1.CreateStudents(names1, "Group1");

            StudentsCreator studentsCreator2 = new StudentsCreator();
            Student[] arrayOfStudents2 = studentsCreator2.CreateStudents(names2, "Group2");

            StudentsCreator studentsCreator3 = new StudentsCreator();
            Student[] arrayOfStudents3 = studentsCreator3.CreateStudents(names3, "Group3");

            //Groups display
            Console.WriteLine("Group1:");
            StudentsDisplayer sd1 = new StudentsDisplayer();
            sd1.DisplayStudents(arrayOfStudents1);

            Console.WriteLine("\nGroup2:");
            StudentsDisplayer sd2 = new StudentsDisplayer();
            sd2.DisplayStudents(arrayOfStudents2);

            Console.WriteLine("\nGroup3:");
            StudentsDisplayer sd3 = new StudentsDisplayer();
            sd3.DisplayStudents(arrayOfStudents3);
            
            BestMark studentsMarks1 = new BestMark();
            BestMark studentsMarks2 = new BestMark();
            BestMark studentsMarks3 = new BestMark();

            //Math Best Marks
            Console.WriteLine("\nBest Math Marks:");
            studentsMarks1.MathBestMark(arrayOfStudents1);
            studentsMarks2.MathBestMark(arrayOfStudents2);
            studentsMarks3.MathBestMark(arrayOfStudents3);

            //Physical Education Best Marks
            Console.WriteLine("\nBest Physical Education Marks:");
            studentsMarks1.PhysicalEducationBestMark(arrayOfStudents1);
            studentsMarks2.PhysicalEducationBestMark(arrayOfStudents2);
            studentsMarks3.PhysicalEducationBestMark(arrayOfStudents3);

            //Biology Best Marks
            Console.WriteLine("\nBest Biology Marks:");
            studentsMarks1.BiologyBestMark(arrayOfStudents1);
            studentsMarks2.BiologyBestMark(arrayOfStudents2);
            studentsMarks3.BiologyBestMark(arrayOfStudents3);

            //Math Average Marks
            Console.WriteLine("\nAverage Math Marks:");
            studentsMarks1.MathAverageMark(arrayOfStudents1);
            studentsMarks2.MathAverageMark(arrayOfStudents2);
            studentsMarks3.MathAverageMark(arrayOfStudents3);

            //Physical Education Average Marks
            Console.WriteLine("\nAverage Physical Education Marks:");
            studentsMarks1.PhysicalEducationAverageMark(arrayOfStudents1);
            studentsMarks2.PhysicalEducationAverageMark(arrayOfStudents2);
            studentsMarks3.PhysicalEducationAverageMark(arrayOfStudents3);

            //Biology Average Marks
            Console.WriteLine("\nAverage Biology Marks:");
            studentsMarks1.BiologyAverageMark(arrayOfStudents1);
            studentsMarks2.BiologyAverageMark(arrayOfStudents2);
            studentsMarks3.BiologyAverageMark(arrayOfStudents3);

            //General Average Mark
            Console.WriteLine("\nGeneral Average Marks:");
            studentsMarks1.GeneralAverageMark(arrayOfStudents1);
            studentsMarks2.GeneralAverageMark(arrayOfStudents2);
            studentsMarks3.GeneralAverageMark(arrayOfStudents3);
        }
    }
}