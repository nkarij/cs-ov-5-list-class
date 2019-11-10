using System;

namespace ov3
{

    class Person
    {
        string name, job, city;
        int age;
        public Person (string name, int age, string city, string jobtitle)
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.job = jobtitle;
        }

        public void presentation() {
            System.Console.WriteLine($"{name} is {age} years old. She/he lives in {city} where she/he works as a {job}");
        }

        
    }
}