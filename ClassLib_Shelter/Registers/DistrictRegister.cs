using ClassLib_Shelter.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Registers
{
    
    public class DistrictRegister : IRegister<District>
    {
        #region Instance fields
        private List<District> _districts;
        #endregion
        #region Properties

        public List<District> Districts 
        { 
            get { return _districts; } 
            set { _districts = value; } 
        }
        #endregion
        #region Constructor
        public DistrictRegister()
        {
            _districts = new List<District>();
        }

        public DistrictRegister(List<District> districts)
        {
            _districts = districts; 
        }
        #endregion
        #region Methods
        public List<District> GetAll() 
        { 
            return new List<District>(_districts); 
        
        }

        public void Add(District newDistrict)
        {
			if (newDistrict == null) throw new ArgumentException("Item");
			if (newDistrict.DistrictId == 0)
			{
				newDistrict.DistrictId = GenId();
			}
			else
			{
				if (GetById(newDistrict.DistrictId) != null)
					throw new ArgumentException("A district with this Id already exists.");
			}
			_districts.Add(newDistrict);
        }
		private int GenId()
		{
			int nextId = 0;
			foreach (District district in _districts)
			{
				if (nextId < district.DistrictId)
				{
					nextId = district.DistrictId;
				}
			}
			return nextId + 1;
		}

		public void Remove(int districtId)
        {

            _districts.Remove(GetById(districtId));


        }

        public District GetById(int districtId) 
        {
            foreach (District district in _districts)
            {
                if (districtId == district.DistrictId) { return district; }
            }
            return null;
        }

        public District Update(int districtId, District updatedDistrict)
        {
            District district = GetById(districtId);

            if (district != null)
            {
                district.DistrictId = updatedDistrict.DistrictId;
                district.Name = updatedDistrict.Name;
                district.AgeGroup = updatedDistrict.AgeGroup;
                district.Location = updatedDistrict.Location;
                district.ContactEmail = updatedDistrict.ContactEmail;
                district.ContactPhone = updatedDistrict.ContactPhone;
            }
            return district;
        }

        public override string ToString()
        {
            string res = "[ ";
            foreach (District district in _districts)
            {
                res += district + " ";
            }
            return res + " ]";
        }

        #endregion
    }
}
