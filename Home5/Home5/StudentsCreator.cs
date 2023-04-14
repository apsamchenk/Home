using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    public class StudentsCreator
    {
        public Student[] CreateStudents(string[] names, string group)
        {
            Student[] arrayOfStudents = new Student[5];
            Random random = new Random();
            
            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                int randId = random.Next(100);
                int randMarkMath = random.Next(1, 11);
                int randMarkPhEd = random.Next(1, 11);
                int randMarkBiology = random.Next(1, 11);
                int randAge = random.Next(18, 23);

                arrayOfStudents[i] = new Student(randId, names[i], randAge, group, randMarkMath, randMarkPhEd, randMarkBiology, 0);
            }

            return arrayOfStudents;
        }
    }
}
