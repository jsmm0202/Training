using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ACM.BL
{
    public class Address : EntityBase
    {
        public Address()
        {
        }
        public Address(int addressId) // add new line 
        {
            AddressId = addressId;
        }


        public int AddressId { get; private set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }

        private readonly int d;
        // you could simplify to this code
        //public override bool Validate() => string.IsNullOrWhiteSpace(PostalCode);
        public override bool Validate()
        {
            var isValid = true; 
            if (string.IsNullOrWhiteSpace(PostalCode))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
