using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MBlog.Model
{
    [Serializable]
    public class BlogPost
    {
        private static readonly XmlDocument XmlDoc = new XmlDocument();

        public BlogPost()
        {
            PostTags = new List<string>();
        }

        public string PostName { get; set; }
        public DateTime PostDate { get; set; }
        public List<string> PostTags { get; set; }

        [XmlIgnore]
        public string PostContent { get; set; }

        [XmlElement("PostContent")]
        public XmlCDataSection PostContentCData
        {
            get { return XmlDoc.CreateCDataSection(PostContent); }
            set { PostContent = value.Data; }
        }

        public static BlogPost Load(string fileName)
        {
            BlogPost post;
            var serializer = new XmlSerializer(typeof (BlogPost));

            if (File.Exists(fileName))
            {
                FileStream fs = null;

                try
                {
                    fs = File.Open(fileName, FileMode.Open, FileAccess.Read);
                }
                catch
                {
                    //return new BlogProject();
                    throw;
                }

                try
                {
                    post = (BlogPost) serializer.Deserialize(fs);
                }
                catch
                {
                    //project = new BlogProject();
                    throw;
                }
                finally
                {
                    fs.Close();
                }
            }
            else
            {
                //project = new BlogProject();
                throw new FileNotFoundException(fileName);
            }

            return post;
        }

        public void Save(string fileName)
        {
            FileStream filestream = null;
            var serializer = new XmlSerializer(typeof (BlogPost));

            filestream = File.Open(fileName, FileMode.Create, FileAccess.Write);

            try
            {
                serializer.Serialize(filestream, this);
            }
            finally
            {
                filestream.Close();
            }
        }
    }
}