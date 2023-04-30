using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Event
    {
        public string? title;
        public DateTime date;
        public int capacity;
        public int reservations;

       public Event(string title, string date, int capacity, int reservations){
            Title = title;
            Date = DateTime.ParseExact(date, "dd/MM/yyyy", null);
            Capacity = capacity;
            Reservations = 0;
       }

       public string Title { get; set;}

       public DateTime Date{
            get{ return date; }
            set{
                if(value < DateTime.Today){
                    throw new ArgumentException("Nope");
                }
                date = value;
            }
       }

       public int Capacity {
            get{ return capacity; }
            set{
                if(value <= 0){
                    throw new ArgumentException("Wrong value (It's negative or equals zero)");
                }
                capacity = value;
            }
       }

        public int Reservations { get; private set; }

        public void Booking(int newReservations){
            if(Reservations + newReservations > capacity){
                throw new ArgumentException("Overbooking");
            } else {
                Reservations += newReservations;
            }
       }

        public void BookingCancellation(int cancellation){
           if(Reservations <=0){
                throw new ArgumentException("");
           }
           Reservations -= cancellation;
        }
        public override string ToString()
        {
            return $"{Date:d}";
        }
    }
}