using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    internal class Penguin : Animal, ICanSwim, ICanFly
    {
        public Penguin(string name, int age, int numberOfLegs) : base(name, age, numberOfLegs)
        {
        }
        public void Swim()
        {
            Console.WriteLine(this.Name + " can swim like a boss!");
        }
        public void Fly()
        {
            Console.WriteLine(this.Name + " can't fly at all... womp womp");
        }
    }
}
