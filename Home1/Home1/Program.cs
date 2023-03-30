using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter User name:");
            var user = Console.ReadLine();
            Console.WriteLine("Hello," + " " + user + "!");
        }
    }
}