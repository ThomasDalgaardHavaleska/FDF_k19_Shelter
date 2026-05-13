using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Model
{
	public class BlogPostSound : BlogPost
	{
		private string _soundPath;
		private string _soundType;

		public BlogPostSound () : base ()
		{
			_soundPath = " ";
			_soundPath = " ";
		}
		public BlogPostSound(string soundPath, string soundType, int id, string titel, string content, DateTime datePublished, bool hasVisited) : base(id, titel, content, datePublished, hasVisited)
		{
			SoundPath = soundPath;
			SoundType = soundType;
		}
		public string SoundPath
		{
			get { return _soundPath; }
			set { _soundPath  = value; }
		}
		public string SoundType
		{
			get{ return _soundType; }
			set{ _soundType = value; }
		}

		public override string ToString()
		{
			return base.ToString() + "Sound Path: " + SoundPath + ", Sound Type: " + SoundType;
		}
	}
}
