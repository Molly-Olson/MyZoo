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
//Animal t = new Animal("Tony", 12, 4);  /// arrrggggg I want all the animals to print out all the things damn it!
Tiger t = new Tiger("Tony", 12, 4);
t.MakeSound();
Monkey m = new Monkey("Lovey", 5, 2); // kk but liiiike there has to be a better way to display the animals than this
m.MakeSound();
// is this below code even doing anything? I'm struggling understanding where things are being printed from I think
List<Animal> animals = new List<Animal>
            {
                new Animal("Billie", 6, 2),
                new Animal("Kimball", 14, 2),
                new Tiger("Tony", 12, 4),
                new Monkey("Lovey",5, 2)
            };

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
            Console.WriteLine($"Dolphin: " + {animal.Name } + " is " + {animal.Age} + " years old.");
            break;
        case 2:
            Console.WriteLine($"Monkey: " + { animal.Name }
            +" is " + { animal.Age}
            +" years old has " + { animal.Legs}
            +" legs, can(not)... " + { ICanFly}
            +".");
            break;
        case 3:
            Console.WriteLine($"Tiger: " + {animal.Name } + " is " + {animal.Age} + " years old has " + {animal.Legs} + " legs, can(not)... " + {ICanFly} + ".");
            break;
        case 4:
            Console.WriteLine("Penguin: *waddle*");
            break;
        case 5:
            viewAnimals = false;
            Console.WriteLine("Thanks for visiting My Zoo! Come back soon!");
            break;
        default:
            Console.WriteLine("Invalid choice. Please select a valid option.");
            break;
    }

}

for (int i = 0; i < 3; i++)
{
    Console.Beep(1000, 500);
}
