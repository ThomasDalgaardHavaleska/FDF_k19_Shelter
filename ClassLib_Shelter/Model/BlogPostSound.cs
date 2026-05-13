using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Model
{
	#region Instance Fields
	public class BlogPostSound : BlogPost
	{
		private string _soundPath;
		private string _soundType;
	#endregion

		#region Constructor
		public BlogPostSound() : base()
		{
			_soundPath = " ";
			_soundPath = " ";
		}
		public BlogPostSound(int id, string titel, string content, DateTime datePublished, bool hasVisited, string soundPath, string soundType) : base(id, titel, content, datePublished, hasVisited)
		{
			SoundPath = soundPath;
			SoundType = soundType;
		}
	#endregion

	#region Properties
		public string SoundPath
		{
			get { return _soundPath; }
			set { _soundPath = value; }
		}
		public string SoundType
		{
			get { return _soundType; }
			set { _soundType = value; }
		}
	#endregion
	#region Mehods

		public override string ToString()
		{
			return base.ToString() + "Sound Path: " + SoundPath + ", Sound Type: " + SoundType;
		}
	#endregion
	}
}
