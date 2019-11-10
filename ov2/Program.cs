using System;

namespace ov2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Animal cat = new Animal("Tarzan", 20);
            cat.talk("buaaah");

            Animal lion = new Animal("King", 7);
            lion.talk("wrooaaaah");

        }
    }
}
