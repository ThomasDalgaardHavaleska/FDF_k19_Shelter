using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Classes
{
	public class Shelter
	
	
	{
# region instancefields
		private int _shelterId;
		private string _name;
		private string _geolocation;
		private string _place;
		private int _maximumCapacity;
#endregion

# region Constructor

		public Shelter()
		{
			_shelterId = 0;
			_name = "";
			_geolocation = "";
			_place = "";
			_maximumCapacity = 0;
		}


		public Shelter(int shelterId, string name, string geolocation, string place, int maximumCapacity)
		{
			_shelterId = shelterId;
			_name = name;
			_geolocation = geolocation;
			_place = place;
			_maximumCapacity = maximumCapacity;
		}

		#endregion

# region Properties
		public int ShelterId
		{
			get { return _shelterId; }
			set { _shelterId = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public string Geolocation
		{ 
			get { return _geolocation; }
			set { _geolocation = value; }
		}

		public string Place
		{
			get { return _place; }
			set { _place = value; }
		}

		public int MaximumCapacity
		{
			get { return _maximumCapacity; }
			set { _maximumCapacity = value; }

		}
		#endregion


# region Methods


		public override string ToString()
			{
			return "ShelterId: " +_shelterId + "Name: " + _name + "Geolocation: " +_geolocation + "Place: " + _place + "MaximumCapacity: " + _maximumCapacity;
			}

		#endregion

	}
}