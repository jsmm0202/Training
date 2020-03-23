using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer()
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            Customer customer = new Customer()
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer()
            {
                FirstName = "Bilbo",
            };
            string expected = "Bilbo";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            Customer c1 = new Customer()
            {
                FirstName = "Bilbo",
            };
            Customer.InstanceCount++;

            Customer c2 = new Customer()
            {
                FirstName = "Frodo",
            };
            Customer.InstanceCount++;

            Customer c3 = new Customer()
            {
                FirstName = "Rosie",
            };
            Customer.InstanceCount++;

            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
