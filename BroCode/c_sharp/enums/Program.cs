using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //? enums = special "class" that contains a set of named integer constants.
            //?         Use enums when you have values that you know will not change.
            //?         To get the integer value from an item, you must explicitly convert to an int
            //?         name = integer

            Console.WriteLine(Planets.Mars + " is a planet #" + (int)Planets.Mars);

            string name = PlanetRadius.Eart.ToString();
            int radius = (int)PlanetRadius.Eart;
            double volume = Volume(PlanetRadius.Eart);

            Console.WriteLine("planet: " + name);
            Console.WriteLine("radius: " + radius + " km");
            Console.WriteLine("volume: " + volume + " km^3");


            Console.ReadKey();
        }
        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }

    enum Planets
    {
        Mercyry = 1,
        Venus = 2,
        Eart = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8
    }
    enum PlanetRadius
    {
        Mercyry = 2439,
        Venus = 6051,
        Eart = 6371,
        Mars = 3389,
        Jupiter = 69991,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622
    }
}