using ClassLib_Shelter.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Registers
{
    public class CommentRegister : IRegister<Comment>
    {
        #region Instance fields
        private List<Comment> _comments;
        #endregion
        #region Constructors
        public CommentRegister()
        {
            _comments = new List<Comment>();
        }
        public CommentRegister(List<Comment> comments)
        {
            _comments = comments;
        }
        #endregion
        #region Properties
        public List<Comment> Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }
        #endregion
        #region Methods
        public List<Comment> GetAll()
        {
            return new List<Comment>(_comments);
        }
        public void Add(Comment newComment)
        {
            _comments.Add(newComment);
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
          
        
        #endregion

    }
}
