using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class CustomerRepository
    {
        List<Customer> _listOfCustomers = new List<Customer>();
        public void AddContentToList(Customer content)
        {
            _listOfCustomers.Add(content);
        }
        public List<Customer> GetCustomers()
        {
            return _listOfCustomers;
        }
        public void DeleteCustomerByID(Customer customerID)
        {
            _listOfCustomers.Remove(customerID);
        }


    }
}
