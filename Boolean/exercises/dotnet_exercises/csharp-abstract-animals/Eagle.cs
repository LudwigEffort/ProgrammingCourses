using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Eagle : Animal, IFlying
    {
        public Eagle(string name) : base(name) {}

        public override void AnimalCall() => Console.WriteLine("ScricScric");

        public override void Eat() => Console.WriteLine("Meat");
        public override string GetName() => name;
        public void Fly() => Console.WriteLine("I'm flying");
    }
}