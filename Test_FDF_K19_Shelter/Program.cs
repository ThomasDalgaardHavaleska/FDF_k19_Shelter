



using ClassLib_Shelter.Classes;
using ClassLib_Shelter.Model;

DateTime DateNow = DateTime.Now;


User user = new User(12,"Lars Olsen", "Lars@olsen.dk", "Felt leder", false, DateNow, null);
Booking b = new Booking();
IRegister<Booking> reg = new BookingRegister();


reg.Add(b);
