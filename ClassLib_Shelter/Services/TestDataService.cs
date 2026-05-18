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

            District district1 = new District(1, "Syd", "Puslinge", "København S", "mail@mail.dk", "+45 1234567");
            districts.Add(district1);
            District district2 = new District(2, "Nord", "Tumlinge", "København N", "mail@mail.dk", "+45 5678");
            districts.Add(district2);
            District district3 = new District(3, "Øst", "Senior Væbnere", "København Ø", "mail@mail.dk", " +45 9101");
            districts.Add(district3);
            District district4 = new District(4, "Vest", "Væbnere", "København V", "mail@mail.dk", "+45 1121");
            districts.Add(district4);
            District district5 = new District(5, "Amager", "TambourKorps", "Amager", "mail@mail.dk", "+45 1314");
            districts.Add(district5);

            //DistrictRegister districtRegister = new DistrictRegister();
            //districtRegister.Add(new District(1, "District 1", "Adults", "Location 1", "
        }
    }
}
