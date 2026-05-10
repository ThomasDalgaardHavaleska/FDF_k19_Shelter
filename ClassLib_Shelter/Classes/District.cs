using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Classes
{
    public class District
    {
        private int _districtId;
        private string _name;
        private string _agegGroup;
        private string _location;
        private string _contactEmail;
        private string _contactPhone;

        public District() 
        { 
            _districtId = 0;
            _name = "";
            _agegGroup = "";
            _location = "";
            _contactEmail = "";
            _contactPhone = "";
        }

        public District(int districtId, string name, string agegGroup, string location, string contactEmail, string contactPhone)
        {
            _districtId=districtId;
            _name=name;
            _agegGroup=agegGroup;
            _location=location;
            _contactEmail=contactEmail;
            _contactPhone=contactPhone;
        }

        public int DistrictId
        {
            get { return _districtId; }
            set { _districtId = value; }
        }

        public string Name
        {
            get {return _name; }
            set {_name = value; }
        }

        public string AgegGroup
        {
            get { return _agegGroup;}
            set { _agegGroup = value; }
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

        public string ConactPhone
        {
            get { return _contactPhone; }
            set { _contactPhone = value; }
        }

        public override string ToString()
        {
            return "DistrictId: " + _districtId + "Name: " + _name + "Agegroup: " + _agegGroup + "Location: " + _location + "ContactEmail: "  + _contactEmail + "ContactPhone: " + _contactPhone;
        }
    }
}
