using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Model
{
	public class Comment

	{
		#region instancefields

		private int _commentId;
		private string _content;
		private User _author;
		private DateTime _datePublished;

		#endregion

		#region constructor
		public Comment()
		{
			_commentId = 0;
			_content = "";
			_author = null;
			_datePublished = DateTime.Now;
		}

		public Comment(int commentId, string content, User author)
		{
			_commentId = commentId;
			_content = content;
			_author = author;
		}
		#endregion

		#region properties

		public int CommentId
		{
			get { return _commentId; }
			set { _commentId = value; }
		}

		public string Content
		{
			get { return _content; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Content cannot be empty.");
				}
				_content = value;
			}
		}

		public User Author
		{
			get { return _author; }

		}
		#endregion
	}
}
