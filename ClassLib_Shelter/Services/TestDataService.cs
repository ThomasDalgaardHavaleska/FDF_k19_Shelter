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

            District district1 = new District(0, "Syd", "Puslinge", "København S", "mail@mail.dk", "+45 1234567");
            districts.Add(district1);
            District district2 = new District(0, "Nord", "Tumlinge", "København N", "mail@mail.dk", "+45 5678");
            districts.Add(district2);
            District district3 = new District(0, "Øst", "Senior Væbnere", "København Ø", "mail@mail.dk", " +45 9101");
            districts.Add(district3);
            District district4 = new District(0, "Vest", "Væbnere", "København V", "mail@mail.dk", "+45 1121");
            districts.Add(district4);
            District district5 = new District(0, "Amager", "TambourKorps", "Amager", "mail@mail.dk", "+45 1314");
            districts.Add(district5);

            //DistrictRegister districtRegister = new DistrictRegister();
            //districtRegister.Add(new District(1, "District 1", "Adults", "Location 1", "
        }

        public void DataUser(UserRegister users)
        {
            District districtUser = new District(0, "Syd", "Puslinge", "København S", "mail@mail.dk", "+45 1234567");
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

            Booking booking1 = new Booking(0, 5, true, "Tumlinge",district, DateTime.Now, DateTime.Now.AddDays(2), shelter1, "Lars Larsen");
            Booking booking2 = new Booking(0, 3, false, "Væbnere", district, DateTime.Now, DateTime.Now.AddDays(1), shelter2, "Hans Hansen");
            Booking booking3 = new Booking(0, 4, true, "Puslinge", district, DateTime.Now, DateTime.Now.AddDays(3), shelter3, "Troels Troelsen");
            Booking booking4 = new Booking(0, 1, false, "SeniorVæbnere",district, DateTime.Now, DateTime.Now.AddDays(4), shelter4, "Anders Christiansen");

            bookings.Add(booking1);
            bookings.Add(booking2);
            bookings.Add(booking3);
        }

        public void DataShelters(ShelterRegister shelters)
        {
            Shelter shelter1 = new Shelter(0, "Shelter 1", "55.813524, 12.302504", "Ganløse-skoven", 5);
            shelters.Add(shelter1);
        
        }
    }
}