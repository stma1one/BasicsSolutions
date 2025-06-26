using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderExample.Models;

namespace BuilderExample.Interface
{
    public interface IBlogPost
    {
        void AddTitle(string title);
        void AddContent(string body);
        void AddAuthor(string author);
        void AddDate(DateTime date);
        void AddCategory(string category);
        void AddTags(IEnumerable<string> tags);
        void AddMetadataTitle(string title);
        void AddMetadataDescription(string description);
        BlogPost Build();
    }
}
