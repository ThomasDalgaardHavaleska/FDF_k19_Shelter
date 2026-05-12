



using ClassLib_Shelter.Registers;
using ClassLib_Shelter.Model;

DateTime DateNow = DateTime.Now;

District district = new District(1, "Syd", "Væbner", "København S", "email@example.com", "+45 12 34 56 78");
User user = new User(12,"Lars Olsen", "Lars@olsen.dk", "Felt leder", false, DateNow, district);
Booking b = new Booking();
IRegister<Booking> reg = new BookingRegister();


reg.Add(b);
