using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBlog.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MBlog.Model.Tests
{
    [TestClass()]
    public class BlogProjectTests
    {

        public BlogProject project;

        [TestInitialize]
        public void TestInit()
        {
            project = new BlogProject();
            project.BlogAddress = "http://test.url.cz";
            project.BlogDescription = "this is a blog description";
            project.BlogName = "Teh uber cool test blog of awesomenesssssss!";
            project.ProjectFile = "testproject.mbproj";
            project.OutputPath = Path.GetTempPath();
            project.BlogFiles.Add(new BlogFile("abcd.file", BlogFileType.Post));
            project.BlogFiles.Add(new BlogFile("efgh.file", BlogFileType.Picture));
            project.BlogFiles.Add(new BlogFile("ijkl.file", BlogFileType.StaticPage));
            project.BlogFiles.Add(new BlogFile("mnop.file", BlogFileType.Other));
        }

        [TestMethod]
        public void ProjectLoadAndSave()
        {
            // our mess will reside in temp directory
            var testfile = project.OutputPath + project.ProjectFile;
            Debug.Print(testfile);
            project.Save(testfile);
            var output = BlogProject.Load(testfile);
            // compare output with predefined values
            Assert.AreEqual(project.BlogAddress, output.BlogAddress);
            Assert.AreEqual(project.BlogDescription,output.BlogDescription);
            Assert.AreEqual(project.BlogName,output.BlogName);
            Assert.AreEqual(project.ProjectFile,output.ProjectFile);
            Assert.IsTrue(project.ContainsFile("abcd.file"));
            File.Delete(testfile);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void LoadProjectFromInvalidFile()
        {
            const string invalidFileContents = "<xml><someelement>nothing here</someelement></xml>";
            var testfile = project.OutputPath + project.ProjectFile;
            File.WriteAllText(testfile,invalidFileContents);
            var output = BlogProject.Load(testfile);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void LoadProjectFromNonExistentFile()
        {
            var output = BlogProject.Load("sadlkfjsadfasdfjlasdfjasldfjd");
        }
    }
}
