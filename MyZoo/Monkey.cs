using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    internal class Monkey : Animal, ICanFly, ICanSwim
    {
        public Monkey(string name, int age, int numberOfLegs) : base(name, age, numberOfLegs)
        {
            Monkey monkey = new Monkey("Lovey", 5, 2);
        }
        public void Swim()
        {
            Console.WriteLine(this.Name + " can swim like a champ!");
        }
        public void Fly()
        {
            Console.WriteLine(this.Name + " can kinda fly, if you count jumping between trees!");
        }
        public override void MakeSound()
        {
            Console.WriteLine(this.Name + " says OOOHOOOH AAAHHHHAAAHHH!");
        }
    }
}
