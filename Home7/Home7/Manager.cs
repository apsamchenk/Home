using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    internal class Manager : Worker, IManageable, ICookable
    {
        //public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Manager(string name) : base(name)
        {
            
        }

        public void FoodCook()
        {
            Console.WriteLine("\nManager is cooking");
        }

        public void ManageWorkers()
        {
            Console.WriteLine("Manager is managing workers");
        }

        public void SolveProblems()
        {
            Console.WriteLine("Manager is solving problems");
        }

        public override string ToString()
        {
            return $"I am manager and my name is {Name}";
        }
    }
}
