using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animal
    {
        protected string name;

        public Animal(string name){
            this.name = name;
        }
        public void Sleep() => Console.WriteLine("ZZZ");
        public abstract void AnimalCall();
        public abstract void Eat();
        public abstract string GetName();
    }
}