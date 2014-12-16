using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using MarkdownDeep;

namespace MBlog.Model
{
    public class BlogGenerator
    {
        public BlogProject Project { get; set; }
        public BlogTemplate Template { get; set; }
        public string OutputPath { get; set; }

        private List<KeyValuePair<string, StringCollection>> _tagsBuffer;
        private List<string> _tagsList;
        public BlogGenerator()
        {
            _tagsList = new List<string>();
            _tagsBuffer = new List<KeyValuePair<string, StringCollection>>();
        }

        public void Generate()
        {
            // enumerate tags from post files
            foreach (var blogFile in Project.BlogFiles)
            {
                var postfile = BlogPost.Load(blogFile.FullFileName);
                foreach (var postTag in postfile.PostTags)
                {
                    var tag = _tagsBuffer.Where(kvp => kvp.Key == postTag);

                }
            }
        }
    }
}
