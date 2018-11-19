using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public enum CustomerType { Current = 1, Past, Potential}
    class Customer
    {
        public CustomerType TypeOfCustomer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CustomerID { get; set; }

        public Customer(CustomerType typeOfCustomer, string firstName, string lastName, string email, int customerID)
        {
            TypeOfCustomer = typeOfCustomer;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CustomerID = customerID;
        }
        public Customer()
        {
        }
    }
}
