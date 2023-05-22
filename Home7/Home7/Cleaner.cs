using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    internal class Cleaner : Worker, ICleanable
    {
        //public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Cleaner(string name) : base(name)
        {
            
        }

        public void Clean()
        {
            Console.WriteLine("\nCleaner is cleaning");
        }

        public override string ToString()
        {
            return $"I am cleaner and my name is {Name}";
        }
    }
}
