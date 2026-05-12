using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Model
{
	public class BlogPostImage : BlogPost
	{
		private string _path;
		private string _type;

		public BlogPostImage() : base ()
		{
			_path = " ";
			_type = " ";
		}
		public BlogPostImage(int id, string titel, string content, DateTime datePublished, bool hasVisited, string path, string type) : base(id,titel,content,datePublished,hasVisited)
		{
			_path = path;
			_type=type;
		}
		public string Path
		{
			get { return _path; }
			set { _path = value; }
		}
		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}
		public override string ToString()
		{
			return base.ToString() + "Path= " + Path + " Type= " + Type;
		}
	}
}
