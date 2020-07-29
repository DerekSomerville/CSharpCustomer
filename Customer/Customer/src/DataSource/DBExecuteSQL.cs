using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace Customer.src.DataSource
{
    public class DBExecuteSQL
    {
        private DBConnection dbConnector = DBConnection.getInstance();
        private SQLiteConnection connection = null;

        private SQLiteConnection getConnection()
        {
            if (this.connection == null)
            {
                this.connection = this.dbConnector.createConnection();
            }
            return this.connection;
        }

        public void switchToInMemory()
        {
            dbConnector.setInMemory();
            this.connection = null;
        }
    }
}
