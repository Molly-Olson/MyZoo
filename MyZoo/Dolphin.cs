using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    internal class Dolphin : Animal, ICanSwim
    {
        public Dolphin(string name, int numberOfLegs) : base(name, numberOfLegs)
        {
        }
        public void Swim()
        {
            Console.WriteLine(this.Name + "Can swim faster than you!");
        }
    }
}
