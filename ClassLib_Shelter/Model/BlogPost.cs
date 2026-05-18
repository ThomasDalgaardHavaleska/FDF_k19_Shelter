using ClassLib_Shelter.Registers;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ClassLib_Shelter.Model
{

	public class BlogPost: IRegister<Comment>
	{
        #region Instance fields
        private int _id;
		private string _titel;
		private string _content;
		private DateTime _datePublished;
		private bool _hasVisited;
		private List<Comment> _comments;
	#endregion
		#region Constructor
		public BlogPost()
		{
			_id = 0;
			_titel = " ";
			_content = " ";
			_datePublished = DateTime.Now;
			_hasVisited = false;
			_comments = new List<Comment>();
		}
		public BlogPost(int id, string titel, string content, DateTime datePublished, bool hasVisited)
		{
			Id = id;
			Titel = titel;
			Content = content;
			DatePublished = datePublished;
			HasVisited = hasVisited;
			Comments = new List<Comment>();
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
		public List<Comment> Comments
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

		// from commentRegister

		public List<Comment> GetAll()
		{
			return new List<Comment>(_comments);
		}
		public void Add(Comment newComment)
		{
			if (newComment == null) throw new ArgumentException("Item");
			if (newComment.CommentId == 0)
			{
				newComment.CommentId = GenId();
			}
			else
			{
				if (GetById(newComment.CommentId) != null)
					throw new ArgumentException("A comment with this Id already exists.");
			}
			_comments.Add(newComment);
		}

		private int GenId()
		{
			int nextId = 0;
			foreach (Comment comment in _comments)
			{
				if (nextId < comment.CommentId)
				{
					nextId = comment.CommentId;
				}
			}
			return nextId + 1;
		}


		public Comment GetById(int commentId)
		{
			foreach (Comment comment in _comments)
			{
				if (comment.CommentId == commentId)
				{
					return comment;
				}
			}
			return null;
		}

		public void Remove(int commentId)
		{
			_comments.Remove(GetById(commentId));
		}
		public Comment Update(int commentId, Comment newComment)
		{
			Comment comment = GetById(commentId);
			if (comment != null)
			{
				comment.Author = newComment.Author;
				comment.Content = newComment.Content;
				comment.DatePublished = newComment.DatePublished;
				return comment;
			}
			return null;

		}

	

		public override string ToString()
		{
			string res = "[ ";	
			foreach (Comment comment in _comments)
			{
				res += comment + " ";
			}
			return "Blogpost Id: " + Id + ", Title: " + Titel + ", Content: " + Content + ", Date published: " + DatePublished + ", Has visited: " + HasVisited + ", Comments: " + res + "]";
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
