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
        public int CageNumber { get; private set; }

        public bool ICanSwim = false;
        public bool ICanFly = false;
        public Animal(string name, int age, int numberOfLegs, int cageNumber, bool ICanSwim, bool ICanFly )
        {
            Name = name;
            Age = age;
            NumberOfLegs = numberOfLegs;
            CageNumber = cageNumber;
            ICanSwim = true;
            ICanFly = true;
        }

        public virtual void MakeSound() // I made this a void instead of a bool because I want tigers to "roar" monkeys to "oohooh aahaah" and my kids to scream lol how do I do that?!
        {
            Console.WriteLine($"{Name} makes sounds, is {Age} years old and has {NumberOfLegs} legs, lives in cage {CageNumber}. Can swim: {ICanSwim}. Can fly: {ICanFly}.");
            return;
        }
    }
}