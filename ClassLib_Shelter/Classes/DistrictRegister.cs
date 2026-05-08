using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Classes
{
    
    public class DistrictRegister
    {
        #region Instance fields
        private List<Booking> _districts;
        #endregion



        #region Properties

        public List<Booking> Districts 
        { 
            get { return _districts; } 
            set { _districts = value; } 
        }
        #endregion
        #region Constructor
        public DistrictRegister()
        {
            _districts = new List<Booking>();
        }

        public DistrictRegister(List<Booking> districts)
        {
            _districts = districts; 
        }
        #endregion
        #region Methods
        public List<Booking> GetAllDistricts() 
        { 
            return new List<Booking>(_districts); 
        
        }

        public void AddDistrict(Booking newDistrict)
        {
            _districts.Add(newDistrict);
        }


        public void RemoveDistrict(int districtId)
        {

            _districts.Remove(GetDistrict(districtId));


        }

        public Booking GetDistrict(int districtId) 
        {
            foreach (Booking district in _districts)
            {
                if (districtId == Booking.DistrictId) { return district; }
            }
            return null;
        }

        public Booking UpdateDistrict(int districtId, Booking updatedDistrict)
        {
            Booking district = GetDistrict(districtId);

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

        public override string ToString()
        {
            string res = " ";
            foreach (Booking district in _districts)
            {
                res += district;
            }
            return res;
        }

        #endregion


    }






}
