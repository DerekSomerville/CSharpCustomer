using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Text;
using System.Data.SQLite;

namespace Customer.src.DataSource
{
    public sealed class DBConnection : DBConnInterface
    {
        private static DBConnection _instance = null;

        private const string dbFileName = "resource/Database/applicationDB.db";
        private const string inMemoryDatabase = ":memory:";
        private string database = dbFileName;

        private DBConnection() {
        }

        public static DBConnection getInstance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }

            return _instance;
        }


        private string getConnString(String databaseName)
        {
            return string.Format("Data Source={0}", databaseName);
        }

        public void setInMemory()
        {
            this.database = inMemoryDatabase;
        }

        public SQLiteConnection createConnection()
        {
            return new SQLiteConnection(getConnString(this.database));
        }


    }
}
