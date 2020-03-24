namespace ACM.BL
{
    using System.Linq;

    public class CustomerRepository
    {
        private readonly AddressRepository _addressRepository;

        public CustomerRepository()
        {
            _addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Bggins";
                customer.AddressList = _addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        // Call an insert procedure
                    }
                    else
                    {
                        // Call an update procedure
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
