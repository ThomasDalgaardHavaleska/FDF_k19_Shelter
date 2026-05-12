using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ClassLib_Shelter.Model
{
	#region Instance fields
	public class BlogPost
	{
		private int _id;
		private string _titel;
		private string _content;
		private DateTime _datePublished;
		private bool _hasVisited;
	#endregion
		#region Constrctor
		public BlogPost() 
		{ 
			_id = 0;
			_titel = " ";
			_content = " ";
			_datePublished = DateTime.Now;
			_hasVisited = false;
		}
		public BlogPost (int id, string titel, string content,DateTime datePublished, bool hasVisited)
		{
			Id = id;
			Titel = titel;
			Content = content;
			DatePublished = datePublished;
			HasVisited = hasVisited;
		}
		#endregion
		#region Properties
		public int Id
		{
			get { return _id; }
			set {
				if( Id == Id ) 
				{
					throw new ArgumentException("That ID already exist");
				}
				
					_id = value; }
		}
		public string Titel
		{
			get { return _titel; }
			set {
				if(string.IsNullOrEmpty(value) || value.Length == 0)
				{
					throw new ArgumentException("Titel can not be empty");
				}
			_titel= value; }
		}
		public string Content
		{
			get { return _content; }
			set {
				if (string.IsNullOrEmpty(value) || value.Length == 0)
				{
					throw new ArgumentException("Content can not be empty");
				}
			
				_content  = value; }
		}
		public DateTime DatePublished
		{
			get { return _datePublished; }
			set { _datePublished = value; }
		}
		public bool HasVisited
		{
			get { return _hasVisited; }	
			set { _hasVisited = value; }
		}
		#endregion
		#region Methods
		public override string ToString()
		{
			return "Id= " + Id + " Titel= " + Titel + " Content= " + Content + " Date published= " + DatePublished + " Has visited= " + HasVisited;
		}

		#endregion
	}
}
