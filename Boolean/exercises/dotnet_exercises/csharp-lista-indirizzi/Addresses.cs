using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public record Addresses
    {
       public Addresses(string name, string surname, string street, string city, string province, string zip){
            Name = name;
            Surname = surname;
            Street = street;
            City = city;
            Province = province;
            Zip = zip;
       }

        public string Name {get; init;}
        public string Surname {get; init;}
        public string Street {get; init;}
        public string City {get; init;}
        public string Province {get; init;}
        public string Zip {get; init;}
    }
}