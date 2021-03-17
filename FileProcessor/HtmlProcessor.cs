using System.Collections.Generic;
using System.IO;

namespace FileProcessor
{
    public class HtmlProcessor : FileProcessor
    {


        protected override List<string> ExtractData(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            string str;
            List<string> stringsFromInputFile = new List<string>();
            while ((str = reader.ReadLine()) != null)
            {
                stringsFromInputFile.Add(str);
            }
            return stringsFromInputFile;
        }
    }
}
