using System;
using System.Collections.Generic;
using System.Text;
using Customer.src.DataSource;

namespace Customer.src.Utilities
{
    public sealed class ErrorLogging
    {
        private static ErrorLogging _instance = null;

        private WriteToFile writeErrorLog = new WriteToFile(DataSourceConstants.ERRORLOG_FOLDER, DataSourceConstants.ERROR_LOG, true);

        private ErrorLogging()
        {

        }
        public static ErrorLogging getInstance()
        {
            if (_instance == null)
            {
                _instance = new ErrorLogging();
            }

            return _instance;
        }

        public void writeToLog(string method, string message)
        {
            Console.WriteLine("Method: " + method + " message: " + message);
            this.writeErrorLog.write(method + "," + message);
        }
    }
}
