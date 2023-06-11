using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9
{
    public class Person
    {
        private int age, salary;
        public string Name { get; set; }
        public int Age { get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new AgeException("Your age is below 18");
                }

                else 
                {
                    age = value;
                }
            }
        }
        public int Salary { get { return salary; }
            set
            {
                if (value < 100)
                {
                    throw new SalaryException("The salary is below 100");
                }

                else
                {
                    salary = value;
                }
            }
        }

        public Person(string name, int age, int salary) 
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}
