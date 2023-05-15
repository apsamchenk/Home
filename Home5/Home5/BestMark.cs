using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    internal class BestMark
    {
        /// <summary>
        /// This method is searching for best Math mark in Group
        /// </summary>
        public void MathBestMark(Student[] arrayOfStudents)
        {
            int maxMathMark = 0;
            string name = "";

            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                int mark = arrayOfStudents[i].MathMark;

                if (mark > maxMathMark)
                {
                    maxMathMark = mark;
                    name = arrayOfStudents[i].Name;
                }
            }

            Console.WriteLine($"Name: {name}, Math mark: {maxMathMark}");
        }

        /// <summary>
        /// This method is searching for best Physical Education mark in Group
        /// </summary>
        public void PhysicalEducationBestMark(Student[] arrayOfStudents)
        {
            int maxPhysicalEducationMark = 0;
            string name = "";

            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                int mark = arrayOfStudents[i].PhysicalEducationMark;

                if (mark > maxPhysicalEducationMark)
                {
                    maxPhysicalEducationMark = mark;
                    name = arrayOfStudents[i].Name;
                }
            }

            Console.WriteLine($"Name: {name}, Physical Education mark: {maxPhysicalEducationMark}");
        }

        /// <summary>
        /// This method is searching for best Biology mark in Group
        /// </summary>
        public void BiologyBestMark(Student[] arrayOfStudents)
        {
            int maxBiologyMark = 0;
            string name = "";

            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                int mark = arrayOfStudents[i].BiologyMark;

                if (mark > maxBiologyMark)
                {
                    maxBiologyMark = mark;
                    name = arrayOfStudents[i].Name;
                }
            }

            Console.WriteLine($"Name: {name}, Biology mark: {maxBiologyMark}");
        }

        /// <summary>
        /// This method calculates Average Math mark in Group
        /// </summary>
        public void MathAverageMark(Student[] arrayOfStudents)
        {
            double mathAverageMark = 0;
            double markSum = 0;
            string group = arrayOfStudents[0].Group;

            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                markSum += arrayOfStudents[i].MathMark;
            }

            mathAverageMark = markSum / arrayOfStudents.Length;

            Console.WriteLine($"{group}, Math Average mark: {mathAverageMark}");
        }

        /// <summary>
        /// This method calculates Average Physical Education mark in Group
        /// </summary>
        public void PhysicalEducationAverageMark(Student[] arrayOfStudents)
        {
            double pEAverageMark = 0;
            double markSum = 0;
            string group = arrayOfStudents[0].Group;

            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                markSum += arrayOfStudents[i].PhysicalEducationMark;
            }

            pEAverageMark = markSum / arrayOfStudents.Length;

            Console.WriteLine($"{group}, Physical Education Average mark: {pEAverageMark}");
        }

        /// <summary>
        /// This method calculates Average Biology mark in Group
        /// </summary>
        public void BiologyAverageMark(Student[] arrayOfStudents)
        {
            double biologyAverageMark = 0;
            double markSum = 0;
            string group = arrayOfStudents[0].Group;

            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                markSum += arrayOfStudents[i].BiologyMark;
            }

            biologyAverageMark = markSum / arrayOfStudents.Length;

            Console.WriteLine($"{group}, Biology Average mark: {biologyAverageMark}");
        }

        /// <summary>
        /// This method calculates Average General mark in Group
        /// </summary>
        public void GeneralAverageMark(Student[] arrayOfStudents)
        {
            double markMathSum = 0;
            double markPESum = 0;
            double markBiologySum = 0;
            double result = 0;

            string group = arrayOfStudents[0].Group;

            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                markMathSum += arrayOfStudents[i].MathMark;
                markPESum += arrayOfStudents[i].PhysicalEducationMark;
                markBiologySum += arrayOfStudents[i].BiologyMark;
            }

            double mathAverageMark = markMathSum / arrayOfStudents.Length;
            double pEAverageMark = markPESum / arrayOfStudents.Length;
            double biologyAverageMark = markBiologySum / arrayOfStudents.Length;

            result = Math.Round((mathAverageMark + pEAverageMark + biologyAverageMark) / 3, 2);

            Console.WriteLine($"{group}, General Average mark: {result}");
        }
    }
}
