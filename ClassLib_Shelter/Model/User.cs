using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ClassLib_Shelter.Model
{
    public class User
    {
        //Instansfelter

        private int _userId;
        private string _fullName;
        private string _email;
        private string _role;
        private bool _isAdmin;
        private DateTime _dateOfCreation;
        private District _districtAssociation;




        //Konstruktører

        //default konstruktør

        public User()
        {
            _userId = 0;
            _fullName = "";
            _email = "";
            _role = "";
            _isAdmin = false;
            _dateOfCreation = DateTime.Now;
            _districtAssociation = null; 

        }

        public User(int userId, string fullName, string email, string role, bool isAdmin, DateTime dateOfCreation, District DistrictAssocation)
        {
            UserId = userId;
            FullName = fullName;
            Email = email;
            Role = role;
            IsAdmin = isAdmin;
            DateOfCreation = dateOfCreation;
            DistrictAssociation = DistrictAssocation;
          
        }


        //Properties

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public bool IsAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; } 
        }

        public DateTime DateOfCreation
        {
            get { return _dateOfCreation;  }
            set { _dateOfCreation = value; }
        }

        public District DistrictAssociation
        { 
            get { return _districtAssociation; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("As a new user, you need to choose a district upon creation");

                }

                _districtAssociation = value;
            }
                
        }


        //Metoder

        //To string-metode

        public override string ToString()
        {
            return
                
                "User with ID: " + UserId + 
                ". \n Fullname: " + FullName + 
                ". \n Email: " + Email +
                ". \n Role: " + Role +
                " . \n Is an Admin?: " + IsAdmin +
                ".  \n District: " + DistrictAssociation +
                ". \n User was created: " + DateOfCreation;
        }

    

    }
}
