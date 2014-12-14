using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MBlog.Model
{
    [Serializable]
    public class BlogProject
    {
        public BlogProject()
        {
            BlogFiles = new List<BlogFile>();
        }

        public string ProjectFile { get; set; }
        public string BlogName { get; set; }
        public string BlogDescription { get; set; }
        public string BlogAddress { get; set; }
        public string OutputPath { get; set; }
        public List<BlogFile> BlogFiles { get; set; }

        public bool ContainsFile(string fileName)
        {
            var r = false;
            foreach (var blogFile in BlogFiles)
            {
                if (blogFile.FileName == fileName) r = true;
            }
            return r;
        }

        public static BlogProject Load(string fileName)
        {
            BlogProject project;
            var serializer = new XmlSerializer(typeof (BlogProject));

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
                    project = (BlogProject) serializer.Deserialize(fs);
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

            return project;
        }

        public void Save(string fileName)
        {
            FileStream filestream = null;
            var serializer = new XmlSerializer(typeof (BlogProject));

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