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

        private AddressRepository addressRepository { get; set; } // remove 'get' 'set'
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

        public bool save(Customer customer) // Save
        {
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        //Call an insert procedure
                    }
                    else
                    {
                        //Call an update procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
