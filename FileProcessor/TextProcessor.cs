using System.Collections.Generic;
using System.IO;

namespace FileProcessor
{
    public class TextProcessor : FileProcessor
    {
        protected override List<string> ExtractData(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            List<string> result = new List<string>();
            string str = reader.ReadLine();
            if ( str != null )
            {
                result.Add(str);
            }
            return result;
        }
    }
}
