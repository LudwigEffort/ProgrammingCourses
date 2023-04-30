using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name) {}

        public override void AnimalCall() => Console.WriteLine("BauBau");

        public override void Eat() => Console.WriteLine("Meat");
        public override string GetName() => name;
    }
}