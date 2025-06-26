using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Models
{
    public class BlogPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public IList<string> Categories { get; set; }
        public IList<string> Tags { get; set; }
        public string MetaDescription { get; set; }
        public string MetadataTitle { get; set; }

        ///this is UGLY
        public BlogPost(string title, string content, string author, DateTime date, IList<string> categories, IList<string> tags, string metaDescription, string metadataTitle)
        {
            Title = title;
            Content = content;
            Author = author;
            Date = date;
            Categories = categories;
            Tags = tags;
            MetaDescription = metaDescription;
            MetadataTitle = metadataTitle;
        }

        public BlogPost()
        {
            Tags = new List<string>();
            Categories = new List<string>();
        }

        public override string ToString()
        {
            string str = string.Empty;

            str += $"{Title}-{Content}//{Author}: {Date} Categories:";

            foreach(var category in Categories)
            {
                str += $"{category}\n";
            }

            

            return str;
        }
    }
}
