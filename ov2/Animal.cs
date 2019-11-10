using System;

namespace ov2
{

    class Animal
    {
        public string name;
        public int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;            
        }


        public void talk(string sound){
            Console.WriteLine($"Hi, Im {name}, {age} yo. My sound is: {sound}");
        }

    }
    
}

