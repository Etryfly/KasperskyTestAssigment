using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FileProcessorTests
{
    public class TextProcessorTests
    {

        [Fact]
        public void ReadEmptyFileTest()
        {
            FileProcessor.FileProcessor fileProcessor = new FileProcessor.TextProcessor();
            string expected = "Data is empty";

            string currentDirectory = Environment.CurrentDirectory;
            fileProcessor.ProcessFile(System.IO.Directory.GetParent(currentDirectory).Parent.Parent.FullName + "/TestFile.txt");

            Assert.Equal(expected, fileProcessor.result);
        }
    }
}
