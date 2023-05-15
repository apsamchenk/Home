using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    internal class Ophthalmologist : Doctor
    {
        public Ophthalmologist(string name, int experience) : base(name, experience)
        {

        }

        public override void Treat()
        {
            base.Treat();
            Console.Write("eyes");
        }
    }
}
