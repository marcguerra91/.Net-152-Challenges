using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class ProgramUI
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        List<Customer> listOfCustomers = new List<Customer>();
        public void Run()
        {

            listOfCustomers = _customerRepository.GetCustomers();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose a menu item:" +
                    "\n1. View list of customers" +
                    "\n2. Create new customer" +
                    "\n3. Update list of customers" +
                    "\n4. Delete customer" +
                    "\n5. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: //View list of Customers
                        ViewCustomers();
                        break;
                    case 2: //Create New Customer
                        NewCustomer();
                        break;
                    case 3: //Update Customer List
                            //UpdateCustomerList
                        break;
                    case 4: //Delete From Customer List
                        DeleteCustomer();
                        break;
                    case 5: //exit
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Response.\n Please select 1-5");
                        Console.ReadLine();
                        break;

                }
            }
        }
        private void ViewCustomers()
        {
            Console.Clear();
            List<Customer> customers = _customerRepository.GetCustomers();
            foreach(Customer content in listOfCustomers)
            {
                Console.WriteLine($"\nID:FirstName\t LastName\t type\t\t Email\n #{content.CustomerID}\t{content.FirstName}\t\t {content.LastName}\t\t {content.TypeOfCustomer}\t\t {content.Email}\n");
            }
        }
        private void NewCustomer()
        {
            Customer AddCustomer = new Customer();
            Console.WriteLine("\nPlease select the type of customer you would like to add:\n" +
                "1.Current Customer\n" +
                "2.Past Customer\n" +
                "3.Potential Customer\n");
            int CustomerInput = int.Parse(Console.ReadLine());
            switch (CustomerInput)
            {
                default:
                    break;
            }
            Customer addCustomer = new Customer();
            Console.WriteLine("\nEnter Customer ID number");
            addCustomer.CustomerID = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter customer first name");
            addCustomer.FirstName = Console.ReadLine();
            Console.WriteLine("\nEnter customer last name");
            addCustomer.LastName = Console.ReadLine();
            Console.WriteLine("\nEnter email to be sent");
            addCustomer.Email = Console.ReadLine();

            _customerRepository.AddContentToList(addCustomer);
        }
        private void DeleteCustomer()
        {
            Console.Clear();
            Console.WriteLine("Enter the ID # of the customer you would like to remove:");
            foreach (Customer content in _customerRepository.GetCustomers())
            {
                Console.WriteLine();
            }
            int deleteCustomerByID = int.Parse(Console.ReadLine());
            foreach(Customer customer in _customerRepository.GetCustomers())
            {
                if (deleteCustomerByID == customer.CustomerID)
                {
                    _customerRepository.DeleteCustomerByID(customer);
                    break;
                }
            }
        }
    }
}
