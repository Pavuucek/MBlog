using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MBlog.Model
{
    [Serializable]
    public class BlogFile
    {
        [XmlAttribute]
        public string FileName { get; set; }

        public string FullFileName
        {
            get { return Path.GetFullPath(FileName); }
        }

        [XmlAttribute]
        public BlogFileType FileType { get; set; }

        public BlogFile(string fileName, BlogFileType fileType)
        {
            FileName = fileName;
            FileType = fileType;
        }

        public BlogFile()
        {
            
        }

        public override string ToString()
        {
            return FileName;
        }
    }
}
