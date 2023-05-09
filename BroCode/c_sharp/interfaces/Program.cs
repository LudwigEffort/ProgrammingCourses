using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //? interface = defines a "contract" that all the classes inheriting from should follow 
            //?             An interface declars "what a class should have"
            //?             An intheriting class defines "how it should do it"
            //?             Benefit = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();

            Console.ReadKey();
        }
    }
    interface IPrey
    {
        void Flee(); //? declared but not implemented
    }
    interface IPredator
    {
        void Hunt(); //? declared but not implemented 
    }
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }
    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food!");
        }
    }
    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish!");
        }
    }
}