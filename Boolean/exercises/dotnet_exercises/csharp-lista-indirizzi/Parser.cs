using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public static class Parser
    {
        public const string InputFile = "addresses.csv";
        public const string OutputFile = "output.txt";

        public static IEnumerable<Addresses> Read(){
            using var input = File.OpenText(InputFile);
            var addresses = new List<Addresses>();

            input.ReadLine();

            while (true){
                string? line = input.ReadLine();
                if (line is null) return addresses;

                var chunks = line.Split(',');

                string name;
                string surname;
                string street;
                string city;
                string province;
                string zip;

                name = chunks[0];
                surname = chunks[1];
                street = chunks[2];
                city = chunks[3];
                province = chunks[4];
                zip = chunks[5];

                var address = new Addresses(name, surname, street, city, province, zip);
                addresses.Add(address);
            }
        }

        public static void Write(IEnumerable<Addresses> addresses){
            using var output = File.CreateText(OutputFile);
            output.WriteLine("Addresses list:");

            foreach (var address in addresses)
            {
                output.WriteLine();
                output.WriteLine("------ Address ------");
                output.WriteLine($"Name: {address.Name}");
                output.WriteLine($"Surname: {address.Surname}");
                output.WriteLine($"Street: {address.Street}");
                output.WriteLine($"City: {address.City}");
                output.WriteLine($"Province: {address.Province}");
                output.WriteLine($"Zip: {address.Zip}");
                output.WriteLine("--------------------");
            }
        }
    }
}