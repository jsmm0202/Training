namespace ACM.BL
{
    public class Address : EntityBase
    {
        public Address()
        {
        }

        public Address(int addressId)
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

        public override bool Validate() => string.IsNullOrWhiteSpace(PostalCode);
    }
}
