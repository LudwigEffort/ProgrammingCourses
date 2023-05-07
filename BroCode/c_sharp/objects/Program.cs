using System;

namespace objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //? object = An instace of a class
            //?          A class can be used as a blueprint to create a objects (OOP)
            //?          objects can have fields & mmethods (characteristics & actions)

            Human human1 = new Human(); //? classic method

            human1.name = "Rick";
            human1.age = 65;

            human1.Eat();
            human1.Sleep();

            Human human2 = new()   //? simplified method
            {
                name = "Morty",
                age = 16
            };

            human2.Eat();
            human2.Sleep();
        }

        class Human
        {
            public string name;
            public int age;

            public void Eat()
            {
                Console.WriteLine(name + " is eating");
            }
            public void Sleep()
            {
                Console.WriteLine(name + " is sleaping");
            }
        }
    }
}