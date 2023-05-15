using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    internal class StudentsDisplayer
    {
        public void DisplayStudents(Student[] arrayOfStudents)
        {
            foreach (Student student in arrayOfStudents)
            {
                Console.WriteLine($"Student Id: {student.Id}, name: {student.Name}, age: {student.Age}, group: {student.Group}, mathMark: {student.MathMark}, physicalEducationMark: {student.PhysicalEducationMark}, biologyMark: {student.BiologyMark}, reward: {student.Reward}");
            }
        }
    }
}
