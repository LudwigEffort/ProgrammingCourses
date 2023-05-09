using System;

namespace ToString_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //? ToString() = converts an objects to its string representation so taht it is suitable for display

            Car car = new Car("Chevy", "Corvette", 2022, "Blue");

            Console.WriteLine(car);

            Console.ReadKey();
        }
    }
    class Car
    {
        string make;
        string model;
        int year;
        string color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
            //string message = "This ia a " + make + " " + model;
            //return message;
            return "This ia a " + make + " " + model;
        }
    }
}