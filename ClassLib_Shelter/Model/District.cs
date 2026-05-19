using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Model
{
	#region Instance Fields
	public class District
    {
        private int _districtId;
        private string _name;
        private List<string> _ageGroup;
        private string _location;
        private string _contactEmail;
        private string _contactPhone;
        private Shelter _shelter;
        private int _numberOfMembers;
        #endregion
        #region Constructor
        public District() 
        { 
            _districtId = 0;
            _name = "";
            _ageGroup = new List<string>();
            _location = "";
            _contactEmail = "";
            _contactPhone = "";
            _shelter = null;
            _numberOfMembers = 0;
        }

        public District(int districtId, string name, List<string> ageGroup, string location, string contactEmail, string contactPhone, int noOfMembers)
        {
            DistrictId = districtId;
            Name = name;
            AgeGroup = ageGroup;
            Location = location;
            ContactEmail = contactEmail;
            ContactPhone = contactPhone;
            Shelter = null;
            NumberOfMembers = noOfMembers;
        }
		#endregion
		#region Properties
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
                if (string.IsNullOrWhiteSpace(value) || value.Length == 0)
				{ 
                    throw new ArgumentNullException("Please enter valid name"); 
                }
                _name = value;
            }
           
        }

        public List<string> AgeGroup
        {
            get { return _ageGroup;}
            set
            {
                foreach (string age in value)
                 {
                    if (string.IsNullOrWhiteSpace(age) || age.Length == 0)
                    {
                        throw new ArgumentNullException("Please enter valid age group");
                    }
                }
              
                _ageGroup = value;
            }
        }

        public string Location
        {
            get { return _location; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length == 0)
                {
                    throw new ArgumentNullException("Please enter valid location");
                }
                _location = value;
            }
        }

        public string ContactEmail
        {
            get { return _contactEmail; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length == 0)
                {
                    throw new ArgumentNullException("Please enter valid Email");
                }
                _contactEmail = value;
            }
        }

        public string ContactPhone
        {
            get { return _contactPhone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length == 0)
                {
                    throw new ArgumentNullException("Please enter valid number");
                }
                _contactPhone = value;
            }
        }

        public Shelter Shelter
        {
            get { return _shelter; }
            set { _shelter = value; }
        }   

        public int NumberOfMembers
        {
            get { return _numberOfMembers; }
            set { _numberOfMembers = value; }
        }
        #endregion
        #region Methods


        public override string ToString()
        {
            string res = "[ ";
            foreach (string s in AgeGroup)
            {
                res += s + ", ";
            }
            res += " ]";

            return "DistrictId: " + _districtId + ", Name: " + _name + ", Agegroup: " + res + ", Location: " + _location + 
                ", ContactEmail: "  + _contactEmail + ", ContactPhone: " + _contactPhone + ", Number of Members: " + NumberOfMembers;
        }
		#endregion

        public void AssignShelter(Shelter shelter)
        {
            Shelter = shelter;
        }

        public void CreateShelter(string name, string geolocation, string place, int maximumCapacity)
        {
            Shelter shelter = new Shelter(0, name, geolocation, place, maximumCapacity);
            AssignShelter(shelter);
        }
    }
}
