using System;
using System.Collections.Generic;
using System.Text;
using Customer.src.DataSource;
using Customer.src.Entities;

namespace Customer.src.EntityDataSourceMapping
{
    public class CustomerDatabaseMapping
    {
        private const string customerTableName = "customer";

        private const int emailAddressPosition = 0;
        private const int firstNamePosition = 1;
        private const int lastNamePosition = 2;
        private const int passwordPosition = 3;

        private string[] dataSourceFields = { "emailAddress", "firstName", "lastName", "password" };

        public List<String[]> getCustomerData()
        {
            ReadDelimitedFile customerFileReader = new ReadDelimitedFile();
            return customerFileReader.getFileData(DataSourceConstants.ENTITIES_FOLDER, customerTableName + DataSourceConstants.FILE_TYPE);
        }

    }
}
