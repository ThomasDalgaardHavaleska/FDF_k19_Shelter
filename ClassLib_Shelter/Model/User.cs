using ClassLib_Shelter;
using ClassLib_Shelter.Registers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using System.Xml.Linq;

namespace ClassLib_Shelter.Model
{
    public class User
    {
        #region Instancefields

        private int _userId;
        private string _fullName;
        private int _age;
        private string _email;
        private string _role;
        private bool _isAdmin;
        private DateTime _dateOfCreation;
        private District _districtAssociation;
        private BlogPostRegister _blogPosts;
     

        #endregion
        #region Constructors
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
            _blogPosts = new BlogPostRegister();

        }

        public User(int userId, string fullName, int age, string email, string role, bool isAdmin, District districtAssocation)
        {
            UserId = userId;
            FullName = fullName;
            Age = age;
            Email = email;
            Role = role;
            IsAdmin = isAdmin;
            DateOfCreation = DateTime.Now;
            DistrictAssociation = districtAssocation;
            BlogPosts = new BlogPostRegister();

        }
        #endregion

        #region properties

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string FullName 
        {
            get { return _fullName; }
            set 
                { if(string.IsNullOrWhiteSpace(value) || value.Length == 0)
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

                if (string.IsNullOrWhiteSpace(value) || value.Length == 0)
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

        public BlogPostRegister BlogPosts
        {
            get { return _blogPosts; }
            set { _blogPosts = value; }
        }

        #endregion
        #region Methods

        public override string ToString()
        {
            return
                
                "User with ID: " + UserId + ", Fullname: " + FullName + ", Email: " + Email + ", Age: " + Age +
               ", Role: " + Role + ", Is an Admin?: " + IsAdmin + ", District: " + DistrictAssociation +
                ", User was created: " + DateOfCreation;
        }

        public void CreateBlogPost(string title, string content, DateTime datePublished, bool hasVisited)
        {
            //int newBlogPostId = _blogPosts.GenId();

            BlogPost newBlogPost = new BlogPost(0, title, content, datePublished, hasVisited);

            
            _blogPosts.Add(newBlogPost);
        }
        public void CreateBlogPostImage(string title, string content, DateTime datePublished, bool hasVisited, string path, string type)
        {
           
            BlogPost newBlogPost = new BlogPostImage(0, title, content, datePublished, hasVisited, path, type);


            _blogPosts.Add(newBlogPost);
        }

        public void CreateBlogPostSound(string title, string content, DateTime datePublished, bool hasVisited, string soundPath, string soundType)
        {
            
            BlogPost newBlogPost = new BlogPostSound(0, title, content, datePublished, hasVisited, soundPath, soundType);


            _blogPosts.Add(newBlogPost);
        }

     

        public void RemoveBlogPost(int blogPostId)
        {

            BlogPosts.Remove(blogPostId);

        }

        public District UpdateDistrict(District updatedDistrict)
        {

            District currentDistrict = DistrictAssociation;

            if (DistrictAssociation != null)
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
        #endregion

    }
}
