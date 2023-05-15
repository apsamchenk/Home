using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    internal class Doctor : Person
    {
        public int Experience { get; set; }

        public Doctor(string name, int experience) : base(name)
        {
            Experience = experience;
        }

        public virtual void Treat()
        {
            Console.Write("Treat ");
        }
    }
}
