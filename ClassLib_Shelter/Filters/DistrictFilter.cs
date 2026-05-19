using System;
using System.Collections.Generic;
using System.Text;
using ClassLib_Shelter.Model;

namespace ClassLib_Shelter.Filters
{
	public class DistrictFilter
	
	
	{
		public List<District> FilterLocation(List<District> districts, string location)
		{
			List<District> result = new List<District>();

			foreach (District district in districts)
			{
				if (district.Location == location)
				{
					result.Add(district);
				}
			}
			return result;

			}
	
		public List<District> FilterAgeGroup(List<District> districts, string ageGroup)
		{
			List<District> result = new List<District>();
			foreach (District district in districts)
			{
				foreach (string age in district.AgeGroup)
                {
                    if (age == ageGroup)
					{
						result.Add(district);
					}
                }
			}
			return result;
		}

		public List<District> FilterName(List<District> districts, string name)
		{
			List<District> result = new List<District>();
			foreach (District district in districts)
			{
				if (district.Name == name)
				{
					result.Add(district);
				}
			}
			return result;
        }

    }
}
