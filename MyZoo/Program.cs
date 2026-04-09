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

        }
    }
}
