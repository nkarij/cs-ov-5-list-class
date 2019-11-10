using System;
using System.Collections.Generic;

namespace ov1
{
    class Program
    {
        static void Main(string[] args)
        {

            // en class attribut?
            List<string> animals = new List<string>();

            // kunne være en metode, addAnimalToList
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Name an animal:");
                string animalName = Console.ReadLine();
                animals.Add(animalName);
            }

            // kunne være en metode, printAnimalList
            Console.WriteLine("Here is a list of your Animals:");
            foreach (string animalname in animals)
            {
                Console.WriteLine(animalname);
            }

        }
    }
}
