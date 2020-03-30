namespace ACM.BL
{
    using System.Collections.Generic;
    using Acme.Common;

    public class Customer : EntityBase, ILoggable
    {
        public Customer()
        {
        }

        public Customer(int customerId = 0)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public static int InstanceCount { get; set; }

        public List<Address> AddressList { get; set; }

        public int CustomerId { get; private set; }

        public int CustomerType { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }

                return fullName;
            }
        }

        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState}";

        public override string ToString() => FullName;

        public override bool Validate() =>
            !string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(EmailAddress);
    }
}
