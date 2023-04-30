using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Puffin : Animal, IFlying, ISwimmer
    {
        public Puffin(string name) : base(name) {}

        public override void AnimalCall() => Console.WriteLine("ClicClic");

        public override void Eat() => Console.WriteLine("Fish");
        public override string GetName() => name;
        public void Fly() => Console.WriteLine("I'm flying");
        public void Swim() => Console.WriteLine("I'm swimming");
    }
}