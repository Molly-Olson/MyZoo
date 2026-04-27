using System;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using MyZoo;

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
Tiger t = new Tiger("Tony", 12, 4);
Monkey m = new Monkey("Lovey", 5, 2);
Dolphin d = new Dolphin("Flirt", 6, 0);
Penguin p = new Penguin("Farkle", 3, 2);

Cage one = new Cage(1); // this is a constructor molly :) so are those up there 
one.AddAnimal(d);
Cage two = new Cage(2);
two.AddAnimal(m);
Cage three = new Cage(3);
three.AddAnimal(t);
Cage four = new Cage(4);
four.AddAnimal(p);
Cage five = new Cage(5);
five.AddAnimal(a);
five.AddAnimal(b);

List<Cage> cages = new List<Cage> { one, two, three, four, five };
foreach (Cage cage in cages)
{
    cage.ShowAnimals();
    cage.MakeSounds();
    Console.WriteLine("");
}

//one.ShowAnimals();
//one.MakeSounds();
//one.ICanFly(); // how do I use the interfaces



//List<Animal> animals = new List<Animal>
//            {
//                new Animal("Billie", 6, 2),
//                new Animal("Kimball", 14, 2),
//                new Tiger("Tony", 12, 4),
//                new Monkey("Lovey",5, 2)
//            };

bool viewAnimals = true;
while (viewAnimals)
{
    Console.WriteLine("");
    Console.WriteLine("Would you like to see my wild things?");
    Console.WriteLine("Press 1. for Dolphin," +
        " 2. for Monkey," +
        " 3. for Tiger," +
        " 4. for Penguin," +
        " 5. to exit");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch(choice)
    {
        case 1:
            Console.WriteLine($"Dolphin: {d.Name} is {d.Age} years old, and has {d.NumberOfLegs} legs.");
            
            break;
        case 2:
            Console.WriteLine($"Monkey: {m.Name} is {m.Age} years old, and has {m.NumberOfLegs} legs.");
            break;
        case 3:
            Console.WriteLine($"Tiger: {t.Name }  is {t.Age} years old, and has {t.NumberOfLegs} legs.");
            break;
        case 4:
            Console.WriteLine($"Penguin: {p.Name} is {p.Age} years old, and has {p.NumberOfLegs} legs.");
            break;
        case 5:
            viewAnimals = false;
            Console.WriteLine("Thanks for visiting My Zoo! Come back soon!");
            break;
        default:
            Console.WriteLine("Invalid choice. Please select a valid option.");
            break;
    }
    //if ()
    //{
        
    //}

}

for (int i = 0; i < 3; i++)
{
    Console.Beep(1000, 500);
}
