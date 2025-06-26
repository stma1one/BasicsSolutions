using BuilderExample.Interface;
using BuilderExample.Interfaces;
using BuilderExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builders
{

    #region שלב 1 : נגדיר מחלקת בילדר היורשת מהממשק
    public class BlogPostBuilder : IBlogPost
    #endregion
    {
        #region שלב 2: נגדיר למחלקה תכונה פרטית שהיא אובייקט מהמחלקה שאותה נרצה ליצור בשלב הסופי
        //נשים לב שהתכונה היא פרטית...
        //ולקריאה בלבד
        private BlogPost blogPost { get; }
        #endregion

        #region שלב 3: נגדיר פעולה בונה המייצרת אובייקט ריק של התכונה
        public BlogPostBuilder()
        {
            blogPost = new BlogPost();
        }
        #endregion

        #region שלב 4: נממש את פעולות הממשק. כל פעולה תעדכן את תכונות האובייקט שלנו
        public void AddAuthor(string author)
        {
            if (string.IsNullOrEmpty(author))
                throw new NullReferenceException("Author cannot be empty");
			blogPost.Author = author;
        }

        public void AddCategory(string category)
        {
            blogPost.Categories.Add(category);
        }
        public void AddContent(string body)
        {
            blogPost.Content = body;
        }

        public void AddDate(DateTime date)
        {
            blogPost.Date = date;
        }

        public void AddMetadataDescription(string description)
        {
            blogPost.MetaDescription = description;
        }

        public void AddMetadataTitle(string title)
        {
            blogPost.MetadataTitle = title;
        }

        public void AddTags(IEnumerable<string> tags)
        {
            blogPost.Tags = tags.ToList();
        }

        public void AddTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
                throw new NullReferenceException("Title cannot be empty");
            blogPost.Title = title;
        }
        #endregion

        #region שלב 5: נגדיר פעולת בילד המחזירה את תכונת האובייקט
        public BlogPost Build()
        {
            return blogPost;
        }
        #endregion
    }
}
