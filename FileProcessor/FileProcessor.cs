using System;
using System.Collections.Generic;

namespace FileProcessor
{
    public abstract class FileProcessor
    {
        public String result;
        public void ProcessFile(string fileName)
        {
            List<String> data = ExtractData(fileName);
            data = PrepareData(data);
            result = AnalyzeData(data);
        }


        private List<String> PrepareData(List<String> data)
        {
            //Do something with data

            return data;
        }

        private String AnalyzeData(List<String> data)
        {
            if (data.Count != 0) return "OK";
            return "Data is empty";
        }

        protected abstract List<String> ExtractData(string fileName);


    }
}
