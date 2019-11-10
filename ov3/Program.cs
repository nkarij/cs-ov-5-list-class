using System;

namespace ov3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Type your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Type your age:");
            string age = Console.ReadLine();
            int ageInt = Convert.ToInt32(age);
            Console.WriteLine("Type your city of living:");
            string city = Console.ReadLine();
            Console.WriteLine("Type your jobtitle:");
            string job = Console.ReadLine();
            
            Console.Clear();
            Person human = new Person(name, ageInt, city, job);
            human.presentation();

        }
    }
}
