namespace ClassLib_Shelter.Classes;

public class ShelterRegister
{
#region Instance fields
        private List<Shelter> _register;
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
            get { return _register; } 
            set { _register = value; } 
        } 
#endregion


        #region Methods
        public List<Shelter> GetAllShelters() 
        { 
            return new List<Shelter>(_register); 
        }
        public void AddShelter(Shelter newShelter)
        {
            _register.Add(newShelter);
        }
        public void RemoveShelter(int shelterId)
        {
            _register.Remove(GetShelter(shelterId));
        }

        public Shelter GetShelter(int shelterId) 
        {
            foreach (Shelter shelter in _register)
            {
                if (shelterId == Shelter.Id) { return shelter; }
            }
            return null;
        }

        public Shelter UpdateShelter(int shelterId, Shelter updatedShelter)
        {
            Shelter shelter = GetShelter(shelterId);

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

        #endregion

}
