using System;
using System.Collections.Generic;
using System.Text;
using ClassLib_Shelter.Model;

namespace ClassLib_Shelter.Filters
{
	public class UserFilter
	
	{
		public List<User> FilterDistrictAss(List<User> users, District districtAssociation)
		{
			List<User> result = new List<User>();

			foreach (User user in users)
			{
				if (user.DistrictAssociation == districtAssociation)
				{
					result.Add(user);
				}
			}
			return result;

		}

		public List<User> FilterRole(List<User> users, string role)
		{
			List<User> result = new List<User>();

			foreach (User user in users)
			{
				if (user.Role == role)
				{
					result.Add(user);
				}
			}
			return result;
		}


		public List<User> FilterAdmin(List<User> users, bool isAdmin)
		{
			List<User> result = new List<User>();
			foreach (User user in users)
			{
				if (user.IsAdmin == isAdmin)
				{
					result.Add(user);
				}
			}
			return result;
		}
	}
}
