using ClassLib_Shelter.Model;

namespace ClassLib_Shelter.Registers;

public class ShelterRegister : IRegister<Shelter>
{
#region Instance fields
        private List<Shelter> _shelters;
        private string _name;
 #endregion


 #region Constructor
 public ShelterRegister() 
        { 
            _name = "";
        } 
	public ShelterRegister(string name)
		{
			_name = name;
		}
#endregion

            

#region Properties
        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }
        public List<Shelter> Register 
        { 
            get { return _shelters; } 
            set { _shelters = value; } 
        } 
#endregion


#region Methods
        public List<Shelter> GetAll() 
        { 
            return new List<Shelter>(_shelters); 
        }
        public void Add(Shelter newShelter)
        {
            _shelters.Add(newShelter);
        }
        public void Remove(int shelterId)
        {
            _shelters.Remove(GetById(shelterId));
        }

        public Shelter GetById(int shelterId) 
        {
            foreach (Shelter shelter in _shelters)
            {
                if (shelterId == shelter.ShelterId) { return shelter; }
            }
            return null;
        }

        public Shelter Update(int shelterId, Shelter updatedShelter)
        {
            Shelter shelter = GetById(shelterId);

            if (shelter != null)
            {
                shelter.ShelterId = updatedShelter.ShelterId;
                shelter.Name = updatedShelter.Name;
                shelter.Geolocation = updatedShelter.Geolocation;
                shelter.Place = updatedShelter.Place;
                shelter.MaximumCapacity = updatedShelter.MaximumCapacity;
            }
            return shelter;
        }

    public override string ToString()
    {
        string res = "[ ";
        foreach (Shelter shelter in _shelters)
        {
            res += shelter + " ";
        }
        return res + " ]";
    }

    #endregion

}
