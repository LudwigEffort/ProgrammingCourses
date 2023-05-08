using System;

namespace abstract_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //? abstract classes = modifier that indicates missing components or incomplete implementation

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();

            Console.ReadKey();
        }

        abstract class Vehicle
        {
            public int speed = 0;

            public void go()
            {
                Console.WriteLine("This vehicle is moving!");
            }
        }

        class Car : Vehicle
        {
            public int wheels = 4;
        }

        class Bicycle : Vehicle
        {
            public int wheels = 2;
        }
        class Boat : Vehicle
        {
            public int wheels = 0;
        }
    }
}
