using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Customer.src.DataSource
{
    public class ReadDelimitedFile
    {
        private string fileDelimitor = ",";
        private const string filePathPrefix = DataSourceConstants.RESOURCE;

        public void setFileDelimitor(String fileDelimitor)
        {
            this.fileDelimitor = fileDelimitor;
        }

        public String[] getRawFileData(String directory, String fileName)
        {
            string[] fileData = null;
            try
            {
                fileData = System.IO.File.ReadAllLines(filePathPrefix + directory + fileName);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.", e.Message);
            }
            return fileData;
        }
        public List<String[]> getFileData(String directory, String fileName)
        {
            List<string[]> fileSeperateData = new List<String[]>();

            try
            {
                string[] fileData = getRawFileData(directory, fileName);

                foreach (string fileRow in fileData) { 
                    fileSeperateData.Add(fileRow.Split(fileDelimitor));
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.", e.Message);
            }

            return fileSeperateData;
        }
    }
}
