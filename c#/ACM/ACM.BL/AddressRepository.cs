using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

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
                PostalCode = "Sunflowers"

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
                PostalCode = "Sunflowers2"

            };
            addressList.Add(address);

            return addressList;
        }

        public bool save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
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
