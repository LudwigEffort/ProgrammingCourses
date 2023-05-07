using System;

namespace constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //? constructor = A special method in a class
            //?               same name as the class name
            //?               Can be used to assign arguments to fields when crating an object 

            Human human1 = new Human("Rick", 65);

            human1.Eat();
            human1.Sleep();

            Human human2 = new Human("Morty", 16);

            human2.Eat();
            human2.Sleep();

            Car car1 = new Car("Ford", "Mustang", 2022, "Red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "Blue");

            car1.Drive();
            car2.Drive();
        }

        class Human
        {
            public string name;
            public int age;

            public Human(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void Eat()
            {
                Console.WriteLine(name + " is eating");
            }
            public void Sleep()
            {
                Console.WriteLine(name + " is sleaping");
            }
        }

        class Car
        {
            public string make;
            public string model;
            int year;
            string color;

            public Car(string make, string model, int year, string color)
            {
                this.make = make;
                this.model = model;
                this.year = year;
                this.color = color;
            }

            public void Drive()
            {
                Console.WriteLine("You drive the " + make + " " + model);
            }
        }

    }
}