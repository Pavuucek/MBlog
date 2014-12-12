using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBlog.Model
{
    public class BlogProject
    {
        public string ProjectFile;
        public string BlogName;
        public string BlogDescription;
        public string BlogAddress;
        public string OutputPath;
        public List<string> BlogFiles { get; set; }

        public BlogProject()
        {
            BlogFiles = new List<string>();
        }

        public bool Load()
        {
            
        }

        public bool Save()
        {
            
        }
    }
}
