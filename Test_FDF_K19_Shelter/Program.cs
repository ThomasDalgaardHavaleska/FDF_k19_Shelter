



using ClassLib_Shelter.Classes;

DateTime DateNow = DateTime.Now;

User user = new User(12,"Lars Olsen", "Lars@olsen.dk", "Felt leder", false, DateNow, null);

Console.WriteLine(user.DateOfCreation);