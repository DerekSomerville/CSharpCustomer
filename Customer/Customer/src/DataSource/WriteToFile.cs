using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Customer.src.DataSource
{
    public class WriteToFile
    {
        private System.IO.StreamWriter fileWriter;
        private const string filePathPrefix = DataSourceConstants.RESOURCE;

        public WriteToFile(String directory, String fileName, Boolean appendToFile)
        {
            this.setFileWriter(directory, fileName, appendToFile);
        }

        public void setFileWriter(string directory, string fileName, Boolean appendToFile)
        {
            try
            {
                fileWriter = new System.IO.StreamWriter(filePathPrefix + directory + fileName, appendToFile);
            }
            catch (IOException ioExp)
            {
                Console.WriteLine("An error occurred.",ioExp.Message);
            }
        }
        public void write(String message)
        {
            try
            {
                fileWriter.WriteLine(message);
            }
            catch (IOException ioExp)
            {
                Console.WriteLine("An error occurred.", ioExp.Message);
            }
        }

        public void closeFileWriter()
        {
            try
            {
                fileWriter.Close();
            }
            catch (IOException ioExp)
            {
                Console.WriteLine("An error occurred.", ioExp.Message);
            }
            this.fileWriter = null;
        }

    }
}
