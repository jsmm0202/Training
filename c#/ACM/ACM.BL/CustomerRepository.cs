using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Bggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        public bool save(Customer customer)
        {
            return true;
        }
    }
}
