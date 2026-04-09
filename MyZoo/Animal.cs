using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    internal class Animal
    {
        public string Name { get; private set; } = "";
        public Animal(string name, int numberOfLegs)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs { get; private set; }

        public string MakeSound() // I made this a string instead of a bool because I want tigers to "roar" monkeys to "oohooh aahaah" and my kids to scream lol how do I do that?!
        {
            Console.WriteLine($"{Name} makes sounds and has {NumberOfLegs} legs."); // how do I call the can swim can fly to display here?
            return ("");
        }
    }
}
