using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Customer.src.EntityDataSourceMapping;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Customer.test
{
    [TestClass()]
    public class TestCustomerDatabaseMapping
    {
        private CustomerDatabaseMapping customerDatabaseMapping;

        public TestCustomerDatabaseMapping()
        {
            customerDatabaseMapping = new CustomerDatabaseMapping();


        }
        [TestMethod()]
        private void testGetCustomerDataLoaded()
        {
            List<string[]> customerData = customerDatabaseMapping.getCustomerData();
            Assert.AreEqual(customerData.Count, 3);
        }
    }
}
