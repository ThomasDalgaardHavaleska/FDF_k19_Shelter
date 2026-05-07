using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Classes
{
    
    public class DistrictRegister
    {
        #region Instance fields
        private List<District> _register;
        private int _id;
        #endregion



        #region Properties
        public int Id 
        { 
            get { return _id; } 
            set { _id = value; } 
        }
        public List<District> Register 
        { 
            get { return _register; } 
            set { _register = value; } 
        }
        #endregion


        #region Methods
        public List<District> GetAllDistricts() 
        { 
            return new List<District>(_register); 
        
        }

        public void AddDistrict(District newDistrict)
        {
            _register.Add(newDistrict);
        }


        public void RemoveDistrict(int districtId)
        {

            _register.Remove(GetDistrict(districtId));


        }

        public District GetDistrict(int districtId) 
        {
            foreach (District district in _register)
            {
                if (districtId == District.DistrictId) { return district; }
            }
            return null;
        }

        public District UpdateDistrict(int districtId, District updatedDistrict)
        {
            District district = GetDistrict(districtId);

            if (district != null)
            {
                district.DistrictId = updatedDistrict.DistrictId;
                district.Name = updatedDistrict.Name;
                district.ClassName = updatedDistrict.ClassName;
                district.Location = updatedDistrict.Location;
                district.ContactEmail = updatedDistrict.ContactEmail;
                district.ContactPhone = updatedDistrict.ContactPhone;
            }
            return district;
        }

        #endregion


    }






}
