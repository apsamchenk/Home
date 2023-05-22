using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    internal class Cook : Worker, ICookable, ICleanable
    {
        //public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Cook(string name) : base(name)
        {
            
        }

        public void Clean()
        {
            Console.WriteLine("\nCook is cleaning");
        }

        public void FoodCook()
        {
            Console.WriteLine("Cook is cooking");
        }

        public override string ToString()
        {
            return $"I am cleaner and my name is {Name}";
        }
    }
}
