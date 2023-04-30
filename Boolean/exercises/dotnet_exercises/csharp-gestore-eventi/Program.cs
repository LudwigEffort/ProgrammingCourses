using csharp_gestore_eventi;

Console.WriteLine("Do you want to organize an event?");

Console.WriteLine("What is the title of the event?");
string Title = Console.ReadLine() ?? "";
Console.WriteLine("What is the date of the event?");
string Date = Console.ReadLine() ?? "";
Console.WriteLine("What is the peaple capacity of the event?");
int Capacity = Convert.ToInt32(Console.ReadLine());
int Reservations = 0;

var firstEvent = new Event(Title, Date, Capacity, Reservations);

Console.WriteLine("This is the summary of yours event:");
Console.WriteLine("Title:" + Title);
Console.WriteLine("Title:" + Date);
Console.WriteLine("Title:" + Capacity);

Console.WriteLine("Do you want to booking a spot?");
int newReservations = Convert.ToInt32(Console.ReadLine());
firstEvent.Booking(newReservations);
Console.WriteLine("These are your reserved spots:" + newReservations);
int availableSpot = Capacity - newReservations;
Console.WriteLine("These are the availabe spots:" + availableSpot);
Console.WriteLine("Would you like to cancel any spots?");
int newCancelReservations = Convert.ToInt32(Console.ReadLine());
firstEvent.BookingCancellation(newCancelReservations);
int newAvailableSpots = Capacity - newReservations + newCancelReservations;
int newReservationsAfter = newReservations - newCancelReservations;

Console.WriteLine("These are your reserved spots:" + newReservationsAfter);
Console.WriteLine("These are available spots:" + newAvailableSpots);