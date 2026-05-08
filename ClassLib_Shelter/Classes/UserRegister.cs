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
		public override string ToString()
		{
			string res = " [";
			foreach (User user in _users)
			{
				res += user + " ]";
			}
			return res;
		}

		public List<User> GetAllUsers()
		{
			return new List<User>(_users); 
		}


		public void AddUser(User newUser)
		{
		_users.Add(newUser);
		}

		public User GetUser(int userId)
		{
		User foundUser = null;
			foreach (User user in _users)
		{
				if (userId == user.UserId)
			{
			return user;
			}
		}
		return foundUser;
		}

		public void RemoveUser(int userid)
		{
			_users.Remove(GetUser(userid));
		}

		public User UpdateUser(int userId, User updatedUser)
		{
			User user = GetUser(userId);
			if (user != null)
			{
			user.FullName = updatedUser.FullName;
			user.Email = updatedUser.Email;
			user.Role = updatedUser.Role;
			}
			return user;
	}
}
}



		#endregion 

	
