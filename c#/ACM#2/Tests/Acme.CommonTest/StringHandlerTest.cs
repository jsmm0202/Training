using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            var source = "SomeTest";
            var expected = "Some Test";

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpaces()
        {
            var source = "Some Test";
            var expected = "Some Test";

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }
    }
}
