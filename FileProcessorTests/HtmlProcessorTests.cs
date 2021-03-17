using System;
using System.IO;
using Xunit;

namespace FileProcessorTests
{
    public class HtmlProcessorTests
    {
        [Fact]
        public void FileNotFoundTest()
        {
            FileProcessor.FileProcessor fileProcessor = new FileProcessor.HtmlProcessor();

            Assert.Throws<FileNotFoundException>(() => fileProcessor.ProcessFile("123"));
        }

        [Fact]
        public void ResultForExistingFileTest()
        {
            FileProcessor.FileProcessor fileProcessor = new FileProcessor.HtmlProcessor();
            string expected = "OK";

            string currentDirectory = Environment.CurrentDirectory;
            fileProcessor.ProcessFile(System.IO.Directory.GetParent(currentDirectory).Parent.Parent.FullName + "/TestFile.html");
            
            Assert.Equal(expected, fileProcessor.result);
        }
    }
}
