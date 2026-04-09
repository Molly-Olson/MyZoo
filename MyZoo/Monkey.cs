using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    internal class Monkey : Animal
    {
        public Monkey(string name, int numberOfLegs) : base(name, numberOfLegs)
        {
            Monkey a = new Monkey("Lovey", 2);
            a.MakeSound();
        }
    }
}
