using ClassLib_Shelter.Model;
using ClassLib_Shelter.Registers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Services
{
    public class TestDataService
    {


        public void DataDistricts(DistrictRegister districts)
        {
            List<string> ageGroup1 = new List<string> { "Puslinge", "Tumlinge" };
            List<string> ageGroup2 = new List<string> { "Væbnere", "Senior Væbnere" };
            District district1 = new District(0, "Syd", ageGroup1, "København S", "mail@mail.dk", "+45 1234567", 50);
            districts.Add(district1);

            District district2 = new District(0, "Nord", ageGroup2, "København N", "mail@mail.dk", "+45 5678", 40);
            districts.Add(district2);
            District district3 = new District(0, "Øst", ageGroup2, "København Ø", "mail@mail.dk", " +45 9101", 25);
            districts.Add(district3);
            District district4 = new District(0, "Vest", ageGroup1, "København V", "mail@mail.dk", "+45 1121", 5);
            districts.Add(district4);
            District district5 = new District(0, "Amager", ageGroup1, "Amager", "mail@mail.dk", "+45 1314", 24);
            districts.Add(district5);
            District district6 = new District(0, "Syd", ageGroup1, "København S", "mail@mail.dk", "+45 1415", 30);

            //DistrictRegister districtRegister = new DistrictRegister();
            //districtRegister.Add(new District(1, "District 1", "Adults", "Location 1", "
        }

        public void DataUser(UserRegister users)
        {
            List<string> ageGroup = new List<string> { "Puslinge", "Tumlinge" };
            District districtUser = new District(0, "Syd", ageGroup, "København S", "mail@mail.dk", "+45 1234567", 20);
            User user1 = new User(1, "John Doe", 24, "john.doe@example.com", "+45 12345678", true, districtUser);

            users.Add(user1);
        }

        public void DataBooking(BookingRegister bookings, UserRegister users, DistrictRegister districts)
        {
            User user = users.GetById(1);
            District district = districts.GetById(1);

            Shelter shelter1 = new Shelter(1, "Shelter 1", "Geolocation 1", "Place 1", 5);
            Shelter shelter2 = new Shelter(2, "Shelter 2", "Geolocation 2", "Place 2", 8);
            Shelter shelter3 = new Shelter(3, "Shelter 3", "Geolocation 3", "Place 3", 10);
            Shelter shelter4 = new Shelter(4, "Shelter 4", "Geolocation 4", "Place 4", 1);

            Booking booking1 = new Booking(0, 5, true, "Tumlinge", district, DateTime.Now, DateTime.Now.AddDays(2), shelter1, "Lars Larsen");
            Booking booking2 = new Booking(0, 3, false, "Væbnere", district, DateTime.Now, DateTime.Now.AddDays(1), shelter2, "Hans Hansen");
            Booking booking3 = new Booking(0, 4, true, "Puslinge", district, DateTime.Now, DateTime.Now.AddDays(3), shelter3, "Troels Troelsen");
            Booking booking4 = new Booking(0, 1, false, "SeniorVæbnere", district, DateTime.Now, DateTime.Now.AddDays(4), shelter4, "Anders Christiansen");

            bookings.Add(booking1);
            bookings.Add(booking2);
            bookings.Add(booking3);
            bookings.Add(booking4);
        }

        public void DataShelter(Shelter shelter)
        {
            shelter.ShelterId = 1;
            shelter.Name = "Ganløse Shelter";
            shelter.Geolocation = "55.813524, 12.302504";
            shelter.Place = "Ganløse-skoven";
            shelter.MaximumCapacity = 5;

        }

        public void DataShelterRegister(ShelterRegister shelterRegister)
        {
            Shelter shelter1 = new Shelter(0, "Shelter 1", "Geolocation 1", "Place 1", 5);
            Shelter shelter2 = new Shelter(0, "Shelter 2", "Geolocation 2", "Place 2", 8);
            Shelter shelter3 = new Shelter(0, "Shelter 3", "Geolocation 3", "Place 3", 10);
            Shelter shelter4 = new Shelter(0, "Shelter 4", "Geolocation 4", "Place 4", 1);
            shelterRegister.Add(shelter1);
            shelterRegister.Add(shelter2);
            shelterRegister.Add(shelter3);
            shelterRegister.Add(shelter4);
        }
    }
}