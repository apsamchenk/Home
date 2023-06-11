using System;

namespace Home9 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            try 
            {
                Person person1 = new Person("Alex", 25, 1200);
                Person person2 = new Person("Adam", 49, 1500);
                Person person3 = new Person("Max", 28, 1900);
                Person person4 = new Person("Alan", 29, 900);
                Person person5 = new Person("Mary", 51, 1400);
                Person person6 = new Person("Henry", 60, 1200);

                persons.Add(person1);
                persons.Add(person2);
                persons.Add(person3);
                persons.Add(person4);
                persons.Add(person5);
                persons.Add(person6);
            }

            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            var peopleWithANames = persons.Where(person => person.Name.StartsWith('A')).Select(person => person.Name);

            Console.WriteLine("People with names starts with A: ");

            foreach (var people in peopleWithANames)
            {
                Console.WriteLine(people);
            }

            var peopleWithSalary = persons.Where(person => person.Age < 30 && person.Salary > 1000).Select(person => person.Name);

            Console.WriteLine("\nPeople with Salary > 1000 and Age < 30: ");

            foreach (var people in peopleWithSalary)
            {
                Console.WriteLine(people);
            }

            var firstPersonWithAgeMoreThen50 = persons.Where(person => person.Age > 50).Select(person => person.Name).First();

            Console.WriteLine("\nFirst person with Age > 50: ");

            Console.WriteLine(firstPersonWithAgeMoreThen50);
        }
    }
}