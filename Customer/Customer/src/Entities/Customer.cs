using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Customer.src.Entities
{
    public class Customer
    {
        public string firstName { get; }
        public string lastName { get; }
        public string emailAddress { get; }
        public string password { get; }
        public static string dataSourceName {get;} = "customer";

        public Customer(String emailAddress, String firstName, String lastName, String password)
        {
            this.emailAddress = emailAddress;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
        }
        public String getName()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
