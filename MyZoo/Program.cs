using System;
using System.Security.Cryptography.X509Certificates;
using MyZoo;
//using static System.Console; k so how do I make this nifty trick work?
// I added this and removed the keyword console below to test and now I am getting an exception error???

namespace MyZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@" __  __       _ _       _       __  __             _           _ 
|  \/  | ___ | | |_   _( )___  |  \/  | __ _  __ _(_) ___ __ _| |
| |\/| |/ _ \| | | | | |// __| | |\/| |/ _` |/ _` | |/ __/ _` | |
| |  | | (_) | | | |_| | \__ \ | |  | | (_| | (_| | | (_| (_| | |
|_|  |_|\___/|_|_|\__, | |___/ |_|  |_|\__,_|\__, |_|\___\__,_|_|
|  \/  | ___ _ __ |___/_  __ _  ___ _ __(_) _|___/               
| |\/| |/ _ \ '_ \ / _` |/ _` |/ _ \ '__| |/ _ \                 
| |  | |  __/ | | | (_| | (_| |  __/ |  | |  __/                 
|_|  |_|\___|_| |_|\__,_|\__, |\___|_|  |_|\___|                 
                         |___/                                   ");
            Console.WriteLine("");
            Console.WriteLine("Welcome to My zoo, this is my circus and these are infact MY monkeys!");
            Console.WriteLine("");
            
            Animal a = new Animal("Billie", 6, 2);
            Animal b = new Animal("Kimball", 14, 2);
            a.MakeSound();
            b.MakeSound();
            //Animal t = new Animal("Tony", 12, 4);  /// arrrggggg I want all the animals to print out all the things damn it!
            Tiger t = new Tiger("Tony", 12, 4);
            t.MakeSound();
            Monkey m = new Monkey("Lovey",5, 2); // kk but liiiike there has to be a better way to display the animals than this
            m.MakeSound();

            //    another way to print the same thing
            //List<Animal> animals = new List<Animal>();
            //animals.Add(a);
            //animals.Add(b);
            //animals.Add(c);
            //animals.Add(d);
            //foreach (Animal animal in animals)
            //{
            //    animal.MakeSound();
            //}

            for (int i = 0; i < 3; i++)
            {
                Console.Beep(1000, 500);
            }
        }
    }
}
