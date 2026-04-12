using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Animal
    {
        public string Name { get; private set; } = "";
        public int Age { get; private set; }
        public int NumberOfLegs { get; private set; }
        public Animal(string name, int age, int numberOfLegs)
        {
            Name = name;
            Age = age;
            NumberOfLegs = numberOfLegs;
        }

        public virtual void MakeSound() // I made this a void instead of a bool because I want tigers to "roar" monkeys to "oohooh aahaah" and my kids to scream lol how do I do that?!
        {
            Console.WriteLine($"{Name} makes sounds, is {Age} years old, and has {NumberOfLegs} legs."); // how do I call the can swim can fly to display here?
            return;
        }
    }
}