using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    internal class Patient : Person
    {
        public IllnessType IlnessType { get; set; }
        public int Age { get; set; }

        public Patient(string name, IllnessType ilnessType, int age) : base(name)
        {
            IlnessType = ilnessType;
            Age = age;
        }
    }
}
