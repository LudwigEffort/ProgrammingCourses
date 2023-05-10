using System;

namespace auto_implemented_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //? Auto-Implemented properties = shortcut when no additional logic is required in the property
            //?                               you do not have to define a field for a property,
            //?                               you only have to write get: and/or set; inside the property

            Car car = new Car("Porsche");

            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
    }
    class Car
    {
        /*
        string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        */

        public string Model { get; set; }

        public Car(string model)
        {
            this.Model = model;
        }
    }
}