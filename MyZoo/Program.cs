using MyZoo;

namespace MyZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My zoo, these are infact MY monkeys!");
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
