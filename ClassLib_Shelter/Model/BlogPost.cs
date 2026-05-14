using ClassLib_Shelter.Registers;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ClassLib_Shelter.Model
{

	public class BlogPost
	{
        #region Instance fields
        private int _id;
		private string _titel;
		private string _content;
		private DateTime _datePublished;
		private bool _hasVisited;
		private CommentRegister _comments;
	#endregion
		#region Constrctor
		public BlogPost()
		{
			_id = 0;
			_titel = " ";
			_content = " ";
			_datePublished = DateTime.Now;
			_hasVisited = false;
			_comments = new CommentRegister();
		}
		public BlogPost(int id, string titel, string content, DateTime datePublished, bool hasVisited)
		{
			Id = id;
			Titel = titel;
			Content = content;
			DatePublished = datePublished;
			HasVisited = hasVisited;
			Comments = new CommentRegister();
		}
		#endregion
		#region Properties
		public int Id
		{
			get { return _id; }
			set
			{
				//if (value == Id)
				//{
				//	throw new ArgumentException("That ID already exist");
				//}

				_id = value;
			}
		}
		public string Titel
		{
			get { return _titel; }
			set
			{
				if (string.IsNullOrEmpty(value) || value.Length == 0)
				{
					throw new ArgumentException("Titel can not be empty");
				}
				_titel = value;
			}
		}
		public string Content
		{
			get { return _content; }
			set
			{
				if (string.IsNullOrEmpty(value) || value.Length == 0)
				{
					throw new ArgumentException("Content can not be empty");
				}

				_content = value;
			}
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
		public CommentRegister Comments
		{
			get { return _comments; }
			set { _comments = value; }
		}
        #endregion
        #region Methods

        public void CreateComment(string content, User author)
        {

            Comment newComment = new Comment(0, content, author);

            Comments.Add(newComment);
        }

        public override string ToString()
		{
			return "Blogpost Id: " + Id + ", Title: " + Titel + ", Content: " + Content + ", Date published: " + DatePublished + ", Has visited: " + HasVisited;
		}

		

  //      public Comment GetById(int id)
		//{

		//	foreach (Comment comment in _comments)
		//	{ 
		//		if (comment.CommentId == id) 
		//				return comment; 
		//	}
		//	return null;
		//}


		//public void Remove(int id)
		//{
		//	Comment commentFound = GetById(Id);
		//	foreach (Comment comment in _comments)
		//	{
		//		if (comment.CommentId == id)
		//		{
		//			_comments.Remove(comment);
		//		}
		//	}
		//}


		#endregion
	}
}
