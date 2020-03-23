using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Bggins"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveInalidEmail()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "invalid",
                FirstName = "Frodo",
                LastName = "Bggins"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreNotEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveInalidFirstName()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "invalid",
                LastName = "Bggins"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreNotEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveInalidLastName()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "invalid"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreNotEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveInalidId()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(5)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Bggins"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreNotEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }


        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Bggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "blabla",
                        StreetLine2 = "Sunflowers",
                        City = "blabla",
                        StateProvince = "Sunflowers",
                        Country = "blabla",
                        PostalCode = "Sunflowers"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "blabla2",
                        StreetLine2 = "Sunflowers2",
                        City = "blabla2",
                        StateProvince = "Sunflowers2",
                        Country = "blabla2",
                        PostalCode = "Sunflowers2"
                    }
                }
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for(int i =0; i<2; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].StateProvince, actual.AddressList[i].StateProvince);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}

