using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Bird : Animal, IFlying
    {
        public Bird(string name) : base(name) {}

        public override void AnimalCall() => Console.WriteLine("PioPio");

        public override void Eat() => Console.WriteLine("Everything");
        public override string GetName() => name;
        public void Fly() => Console.WriteLine("I'm flying");
    }
}