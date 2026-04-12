using System.Reflection;
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
            Console.WriteLine("Welcome to My zoo, this is my circus and these are infact MY monkeys!");
            Animal a = new Animal("Billie", 2);
            Animal b = new Animal("Kimball", 4);
            a.MakeSound();
            b.MakeSound();
            Tiger c = new Tiger("Tony", 4);
            c.MakeSound();
            Monkey d = new Monkey("Lovey", 2); // kk but liiiike there has to be a better way to display the animals than this
            d.MakeSound(); // I wanna see names and what animal it is also sure it makes sound but do they fly or swim? Arg

        }
    }
}
