using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    internal class Restaurant
    {
        public string Title { get; set; }

        public Worker[] Workers { get; set; }

        public Restaurant(string title, Worker[] workers)
        {
            Title = title;
            Workers = workers;
        }

        public void Run(Restaurant restaurant) 
        {
            Console.WriteLine($"Restaurant title: {restaurant.Title}");

            foreach (Worker worker in Workers) 
            {
                Work(worker);
            }
        }

        public void Work(Worker worker)
        {
            if (worker is ICleanable cleaner)
            {
                cleaner.Clean();
            }

            if (worker is ICookable cook)
            {
                cook.FoodCook();
            }

            if (worker is IManageable manager)
            {
                manager.ManageWorkers();
                manager.SolveProblems();
            }
        }
    }
}
