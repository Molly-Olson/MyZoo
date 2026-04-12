using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    internal class Dolphin : Animal, ICanSwim, ICanFly
    {
        public Dolphin(string name, int age, int numberOfLegs) : base(name, age, numberOfLegs)
        {
        }
        public void Fly()
        {
            Console.WriteLine(this.Name + " can't fly at all... womp womp");
        }
        public void Swim()
        {
            Console.WriteLine(this.Name + " can swim faster than you!");
        }
    }
}
