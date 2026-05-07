using System;
using System.Collections.Generic;
using System.Text;
using ClassLib_Shelter.Classes;

namespace ClassLib_Shelter.Classes
{
	public class UserRegister
	{
		private List<User> _users;

		public UserRegister()
		{
			_users = new List<User>();
		}
		public UserRegister(List<User> users)
		{
			_users = users;
		}
		public List<User> Users
		{
			get { return _users; }
			set { _users = value; }
		}

		#region Methods
		public override string ToString();
		{
			string res = " ";
			foreach (User user in _user)
			{
				res = res + user + " User= " + user.Name
			}
			return res;
		}

		public UserRegister GetAllUsers(List<User>users);
		{
			return new List<UserRegister>(users);
		}

		public UserRegister GetUser(int id);
		{
		UserRegister foundUser = null;
		foreach (UserRegister user in _user)
		{
			if (user.Id == id)
			{
			return id;
			}

		}
		return foundUser;
		}

	}
}
}



		#endregion 

	}
}
