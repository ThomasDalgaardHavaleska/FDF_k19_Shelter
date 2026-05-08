using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Classes
{
    
    public class DistrictRegister
    {
        #region Instance fields
        private List<District> _districts;
        private int _id;
        #endregion



        #region Properties
        public int Id 
        { 
            get { return _id; } 
            set { _id = value; } 
        }
        public List<District> Districts 
        { 
            get { return _districts; } 
            set { _districts = value; } 
        }
        #endregion
        #region Constructor
        public DistrictRegister()
        {
            _id = 0;
            _districts = new List<District>();
        }

        public DistrictRegister(int id, List<District> register)
        {
            _id = id;
            _districts = register; 
        }
        #endregion
        #region Methods
        public List<District> GetAllDistricts() 
        { 
            return new List<District>(_districts); 
        
        }

        public void AddDistrict(District newDistrict)
        {
            _districts.Add(newDistrict);
        }


        public void RemoveDistrict(int districtId)
        {

            _districts.Remove(GetDistrict(districtId));


        }

        public District GetDistrict(int districtId) 
        {
            foreach (District district in _districts)
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
