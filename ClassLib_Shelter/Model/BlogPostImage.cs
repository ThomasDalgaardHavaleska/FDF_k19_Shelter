using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Model
{


	public class BlogPostImage : BlogPost
    #region Instance Fields
    {
        private string _imagePath;
		private string _imageType;
#endregion


#region Constructor
		public BlogPostImage() : base ()
		{
			_imagePath = " ";
			_imageType = " ";
		}
		public BlogPostImage(int id, string titel, string content, DateTime datePublished, bool hasVisited, string imagePath, string imageType) : base(id,titel,content,datePublished,hasVisited)
		{
			_imagePath = imagePath;
			_imageType = imageType;
		}
#endregion

#region Properties
		public string ImagePath
		{
			get { return _imagePath; }
			set { _imagePath = value; }
		}
		public string ImageType
		{
			get { return _imageType; }
			set { _imageType = value; }
		}
#endregion

#region Mehods
		public override string ToString()
		{
			return base.ToString() + ", Path: " + ImagePath + ", Type: " + ImageType;
		}
#endregion
	}
}
