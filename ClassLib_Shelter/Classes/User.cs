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
        private string _fullname;
        private string _email;
        private string _role;
        private DateTime _dateOfCreation;
        private District _districtAssociation;




        //Konstruktører

        //default konstruktør

        public User()
        {
            _userId = 0;
            _fullname = "";
            _email = "";
            _role = "";
            _dateOfCreation = DateTime.Now;
            _districtAssociation = null; //Vi skal vel have at en bruger skal have en default-kreds fra starten af?

        }

        public User(int userId, string fullname, string email, string role, DateTime dateOfCreation, District DistrictAssocation)
        {
            _userId = userId;
            _fullname = fullname;
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

        public string Fullname
        {
            get { return _fullname; }
            set { _fullname = value; }
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

        public District DistrictAssociation
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
                ". \n Fullname: " + Fullname + 
                ". \n Email: " + Email
                + ". \n Role: " + Role + 
                ". \n User was created: " + DateOfCreation;
        }

        //void ChangeDistrict(District newDisctrict) bør ikke være en metode for sig, men gøres under dens property
        //{



        //}

    }
}
