using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    internal class Tiger : Animal, ICanSwim
    {
        public Tiger(string name, int numberOfLegs) : base(name, numberOfLegs)
        {
        }
            public void Swim()
        { 
            Console.WriteLine(this.Name + " can swim like a champ!");
            //Tiger a = new Tiger("Tony", 4);
            //a.MakeSound();
        }
    }
}

