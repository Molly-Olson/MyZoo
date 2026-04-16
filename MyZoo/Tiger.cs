using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    internal class Tiger : Animal, ICanSwim, ICanFly
    {
        public Tiger(string name, int age, int numberOfLegs) : base(name, age, numberOfLegs)
        {
            Tiger tiger = new Tiger("Tony", 12, 4);
        }
            public void Swim()
        { 
            Console.WriteLine(this.Name + " can swim like a champ!");
        }
        public void Fly()
        {
            Console.WriteLine(this.Name + " can't fly at all... womp womp");
        }
        public override void MakeSound()
        {
            Console.WriteLine(this.Name + " says ROAR!");
        }
    }
}

