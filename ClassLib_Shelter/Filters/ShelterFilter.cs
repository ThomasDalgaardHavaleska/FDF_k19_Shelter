using System;
using System.Collections.Generic;
using System.Text;
using ClassLib_Shelter.Model;

namespace ClassLib_Shelter.Filters
{
	public class ShelterFilter
	{

		public List<Shelter> FilterLocation(List<Shelter> shelters, string place)
		{
			List<Shelter> result = new List<Shelter>();

			foreach (Shelter shelter in shelters)
			{
				if (shelter.Place == place)
				{
					result.Add(shelter);
				}
			}
			return result;
		}
	
		public List<Shelter> FilterMaxCapacity(List<Shelter> shelters, int maxCapacity)
		{
			List<Shelter> result = new List<Shelter>();
			
			foreach (Shelter shelter in shelters)
			{
				if (shelter.MaximumCapacity >= maxCapacity)
				{
					result.Add(shelter);
				}
			}
			return result;
		}
		
		
		
		
		
		}
}