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
        private int _age;
        private string _email;
        private string _role;
        private bool _isAdmin;
        private DateTime _dateOfCreation;
        private District _districtAssociation;
        private BlogPost _blogPost;




        //Konstruktører

        //default konstruktør

        public User()
        {
            _userId = 0;
            _fullName = "";
            _age = 0;
            _email = "";
            _role = "";
            _isAdmin = false;
            _dateOfCreation = DateTime.Now;
            _districtAssociation = null;
            _blogPost = null;

        }

        public User(int userId, string fullName, int age, string email, string role, bool isAdmin, District DistrictAssocation)
        {
            UserId = userId;
            FullName = fullName;
            Age = _age;
            Email = email;
            Role = role;
            IsAdmin = isAdmin;
            DateOfCreation = DateTime.Now;
            DistrictAssociation = DistrictAssocation;
                     
        }


        //Properties

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string FullName //Lav ArgumentationException ift. null og whitespace
        {
            get { return _fullName; }
            set 
                { if(value == null)
                    throw new ArgumentNullException("Fullname cannot be empty. Type in your fullname."); 
                
                _fullName = value; }
        }

        public int Age 
        {
            get { return _age; }
            set
            {
                if (value < 16 )
                {
                    throw new ArgumentException("Age cannot be negative or less than 16 years");
                }
                _age = value;
            }
        }

        public string Email 
        {
            get { return _email; }
            set
            {

                if (value == null)
                    throw new ArgumentNullException("Mail cannot be empty. Type in a valid mail adress.");

                _email = value;
            }
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

        public BlogPost BlogPost
        {
            get { return _blogPost; }
            set { _blogPost = value; }
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

        public void CreateBlogPost(int blogPostId, string title, string content, DateTime datePublished, bool hasVisited)
        {
            BlogPost existingBlogPost = _blogPosts.GetById(blogPostId);

            if(existingBlogPost == null)
            { 
                throw new ArgumentException("A blogpost with an identical Id already exists. Update Id to continue"); 
            }

            BlogPost newBlogPost = new BlogPost(blogPostId, title, content, datePublished, hasVisited);

            _blogPosts.Add(newBlogPost);
        }

        public void RemoveBlogPost(int blogPostId)
        {

            _blogPosts.Remove(GetById(blogPostId));

        }

        public District Update(int districtId, District updatedDistrict)
        {
            District currentDistrict = GetById(districtId);

            if (currentDistrict != null)
            {
                currentDistrict.DistrictId = updatedDistrict.DistrictId;
                currentDistrict.Name = updatedDistrict.Name;
                currentDistrict.AgeGroup = updatedDistrict.AgeGroup;
                currentDistrict.Location = updatedDistrict.Location;
                currentDistrict.ContactEmail = updatedDistrict.ContactEmail;
                currentDistrict.ContactPhone = updatedDistrict.ContactPhone;
                
            }
            return currentDistrict;
        }


    }
}
