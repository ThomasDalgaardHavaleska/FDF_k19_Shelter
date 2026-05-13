using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Model
{
    public class District
    {
        private int _districtId;
        private string _name;
        private string _ageGroup;
        private string _location;
        private string _contactEmail;
        private string _contactPhone;

        public District() 
        { 
            _districtId = 0;
            _name = "";
            _ageGroup = "";
            _location = "";
            _contactEmail = "";
            _contactPhone = "";
        }

        public District(int districtId, string name, string ageGroup, string location, string contactEmail, string contactPhone)
        {
            _districtId = districtId;
            _name = name;
            _ageGroup = ageGroup;
            _location = location;
            _contactEmail = contactEmail;
            _contactPhone = contactPhone;
        }

        public int DistrictId
        {
            get { return _districtId; }
            set { _districtId = value; }
        }

        public string Name
        {
            get {return _name; }
            set 
            {
                if (_name == null) // if(string.IsNullOrWhiteSpace(value) || value.Length == 0)
				{ 
                    throw new ArgumentNullException("Please enter valid name"); 
                }
                _name = value;
            }
           
        }

        public string AgeGroup
        {
            get { return _ageGroup;}
            set
            {
                if (_ageGroup == null) //if(string.IsNullOrWhiteSpace(value) || value.Length == 0)
				{
                    throw new ArgumentNullException("Please enter valid age group");
                }
                _ageGroup = value;
            }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public string ContactEmail
        {
            get { return _contactEmail; }
            set { _contactEmail = value; }
        }

        public string ContactPhone
        {
            get { return _contactPhone; }
            set { _contactPhone = value; }
        }


        public override string ToString()
        {
            return "DistrictId: " + _districtId + ", Name: " + _name + ", Agegroup: " + _ageGroup + ", Location: " + _location + ", ContactEmail: "  + _contactEmail + ", ContactPhone: " + _contactPhone;
        }
    }
}
