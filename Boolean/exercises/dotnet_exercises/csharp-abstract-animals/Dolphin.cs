using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Dolphin : Animal, ISwimmer
    {
        public Dolphin(string name) : base(name) {}

        public override void AnimalCall() => Console.WriteLine("ClicClic");

        public override void Eat() => Console.WriteLine("Fish");
        public override string GetName() => name;
        public void Swim() => Console.WriteLine("I'm swimming");
    }
}