using ClassLib_Shelter.Model;

namespace ClassLib_Shelter.Registers
{
	public class UserRegister : IRegister<User>
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


		public List<User> GetAll()
		{
			return new List<User>(_users); 
		}


		public void Add(User newUser)
		{
		_users.Add(newUser);
		}

		public User GetById(int userId)
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

		public void Remove(int userid)
		{
			_users.Remove(GetById(userid));
		}

		public User Update(int userId, User updatedUser)
		{
			User user = GetById(userId);
			if (user != null)
			{
			user.UserId = userId;
			user.FullName = updatedUser.FullName;
			user.Email = updatedUser.Email;
			user.Role = updatedUser.Role;
			}
			return user;
	}

        public override string ToString()
        {
            string res = " [";
            foreach (User user in _users)
            {
                res += user + " ]";
            }
            return res;
        }
    }
}



		#endregion 

	
