namespace ACM.BL
{
    using System.Collections.Generic;

    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            // should use var
            Address address = new Address(addressId);

            // use '?' operator....
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "blabla";
                address.StreetLine2 = "Sunflowers";
                address.City = "blabla";
                address.StateProvince = "Sunflowers";
                address.Country = "blabla";
                address.PostalCode = "Sunflowers";
            }

            return address;
        }

        // if you choose to use 'IEnumerable' you should use 'yield return' 
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "blabla",
                StreetLine2 = "Sunflowers",
                City = "blabla",
                StateProvince = "Sunflowers",
                Country = "blabla",
                PostalCode = "Sunflowers",
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "blabla2",
                StreetLine2 = "Sunflowers2",
                City = "blabla2",
                StateProvince = "Sunflowers2",
                Country = "blabla2",
                PostalCode = "Sunflowers2",
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            var success = true; // remove this varibale

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
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
                    success = false; // here return false
                }
            }
            return success; //return true
        }
    }
}
