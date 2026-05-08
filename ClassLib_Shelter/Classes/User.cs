using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ClassLib_Shelter.Classes
{
    public class User
    {
        //Instansfelter

        private int _userId;
        private string _fullName;
        private string _email;
        private string _role;
        private DateTime _dateOfCreation;
        private Booking _districtAssociation;




        //Konstruktører

        //default konstruktør

        public User()

            //Gennemgå klassen med de andre i morgen
        {
            _userId = 0;
            _fullName = "";
            _email = "";
            _role = "";
            _dateOfCreation = DateTime.Now;
            _districtAssociation = null; //Vi skal vel have at en bruger skal have en default-kreds fra starten af?

        }

        public User(int userId, string fullName, string email, string role, DateTime dateOfCreation, Booking DistrictAssocation)
        {
            _userId = userId;
            _fullName = fullName;
            _email = email;
            _role = role;
            _dateOfCreation = dateOfCreation;
            _districtAssociation = DistrictAssocation;
          
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

        public DateTime DateOfCreation
        {
            get { return _dateOfCreation;  }
            set { _dateOfCreation = value; }
        }

        public Booking DistrictAssociation
        { 
            get { return _districtAssociation; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("As a new user, you need to choose a district");

                    _districtAssociation = value;
                }
            }
                
        }


        //Metoder

        //To string-metode

        public override string ToString()
        {
            return 
                "User with ID: " + UserId + 
                ". \n Fullname: " + FullName + 
                ". \n Email: " + Email
                + ". \n Role: " + Role + 
                ". \n User was created: " + DateOfCreation;
        }

    

    }
}
