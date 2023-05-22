using Home7;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cleaner cleaner = new Cleaner("Michael");
            Cook cook = new Cook("Alex");
            Manager manager = new Manager("Emma");

            Worker[] workers = new Worker[] { cleaner, cook, manager };

            Restaurant restaurant = new Restaurant("Omega", workers);

            restaurant.Run(restaurant);
        }
    }
}