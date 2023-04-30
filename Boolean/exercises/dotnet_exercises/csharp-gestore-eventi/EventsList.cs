using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class EventsList
    {
       public EventsList(string title){
            Title = title;
            Events = new List<Event>();
       }
        public string Title { get; set; }
        public List<Event> Events { get; set; }
    }
}