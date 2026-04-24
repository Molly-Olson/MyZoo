using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    internal class Cage 
    {
        public int CageNumber { get; set; }
        private List<Animal> animals;
        public Cage(int number)
        {
            CageNumber = number;
            animals = new List<Animal>();
        }
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public void ShowAnimals()
        {
            Console.WriteLine($"Cage {CageNumber} contains: ");
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.Name} ({animal.GetType().Name})");
            }
        }
        public void MakeSounds()
        {
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }
        
        
    }
}
