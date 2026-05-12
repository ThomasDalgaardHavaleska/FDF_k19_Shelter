using System;
using System.Collections.Generic;
using System.Text;
using ClassLib_Shelter.Model;

namespace ClassLib_Shelter.Registers
{
	#region Instance Fields
	public class BlogPostRegister : IRegister<BlogPost>
	{
		private List<BlogPost> _blogPosts;
	#endregion
		#region Constructor
		public BlogPostRegister()
		{
			_blogPosts = new List<BlogPost>();
		}
		public BlogPostRegister(List<BlogPost> blogPosts)
		{
			BlogPosts = blogPosts;
		}
		#endregion
		#region Properties
		public List<BlogPost> BlogPosts
		{
			get { return _blogPosts; }
			set { _blogPosts = value; }
		}
		#endregion
		#region Methods

		public BlogPost GetById(int id)
		{
			foreach (BlogPost blogPost in _blogPosts)
			{
				if (blogPost.Id == id)
				{
					return blogPost;
				}
			}
			return null;
		}

		public void Remove(int id)
		{
			BlogPost blogPostToRemove = GetById(id);
			if (blogPostToRemove == null)
			{
				throw new ArgumentException("BlogPost not found");
			}
			_blogPosts.Remove(blogPostToRemove);
		}

		public void Add(BlogPost newBlogPost)
		{
			if (newBlogPost == null)
				throw new ArgumentException("Item");
			foreach (BlogPost blogPost in _blogPosts)
			{
				if (blogPost.Id == blogPost.Id)
					throw new ArgumentException("Blogpost with that ID already exist");
			}
			_blogPosts.Add(newBlogPost);
		}

		public List<BlogPost> GetAll()
		{
			return new List<BlogPost>(_blogPosts);
		}

		public BlogPost Update(int id,  BlogPost updatedBlogpost)
		{
		BlogPost blogpost = GetById(id);
		if (blogpost != null)
			{ 
				blogpost.Titel = updatedBlogpost.Titel;
				blogpost.Content = updatedBlogpost.Content;
				return blogpost;
			}
			throw new ArgumentException("Blogpost not found.");
		}

	}

		#endregion
}

