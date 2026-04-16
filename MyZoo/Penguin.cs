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
            Penguin penguin = new Penguin("Penny", 3, 2);
        }
        public void Swim()
        {
            Console.WriteLine(this.Name + " can swim like a boss!");
        }
        public void Fly()
        {
            Console.WriteLine(this.Name + " can't fly at all... womp womp");
        }

        public new int CageNumber { get; private set; }  // I'm not sure why VS wanted the keyword new here
            public void AssignCage(int number)
            {
                CageNumber = 4;
            Console.WriteLine(this.Name + " has been assigned to cage number " + base.CageNumber);
        }
    }
}
