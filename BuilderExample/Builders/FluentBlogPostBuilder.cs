using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderExample.Models;

namespace BuilderExample.Builders
{
    #region שלב 1 : נגדיר מחלקת בילדר היורשת מהממשק
    public class FluentBlogPostBuilder
    #endregion
    {
        #region שלב 2: נגדיר למחלקה תכונה פרטית שהיא אובייקט מהמחלקה שאותה נרצה ליצור בשלב הסופי
        //נשים לב שהתכונה היא פרטית...
        //ולקריאה בלבד
        private BlogPost blogPost { get; }
        #endregion

        #region שלב 3: נגדיר פעולה בונה המייצרת אובייקט ריק של התכונה
        public FluentBlogPostBuilder()
        {
            blogPost = new BlogPost();
        }
        #endregion

        #region שלב 4: נממש את פעולות הממשק. כל פעולה תעדכן את תכונות האובייקט שלנו
        ///רק הפעם הפעולות לא יהיו וויד אלא יחזירו אובייקט מסוג הבילדר שלנו
        //בכל הפעולות נחזיר את האובייקט הנוכחי
        public FluentBlogPostBuilder WithAuthor(string author)
        {
            blogPost.Author = author;
           
            return this;
        }

        public FluentBlogPostBuilder WithCategory(string category)
        {
            blogPost.Categories.Add(category);
            return this;
        }
        public FluentBlogPostBuilder WithContent(string body)
        {
            blogPost.Content = body;
            return this;
        }

        public FluentBlogPostBuilder WithDate(DateTime date)
        {
            blogPost.Date = date;
            return this;
        }

        public FluentBlogPostBuilder WithMetadataDescription(string description)
        {
            blogPost.MetaDescription = description;
            return this;
        }

        public FluentBlogPostBuilder WithMetadataTitle(string title)
        {
            blogPost.MetadataTitle = title;
            return this;
        }

        public FluentBlogPostBuilder WithTags(IEnumerable<string> tags)
        {
            blogPost.Tags = tags.ToList();
            return this;
        }

        public FluentBlogPostBuilder WithTitle(string title)
        {
            blogPost.Title = title;
            return this;
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
