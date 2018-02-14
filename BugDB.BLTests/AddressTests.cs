using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugDB.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugDB.BL.Tests
{
    [TestClass()]
    public class AddressTests
    {
        [TestMethod()]
        public void RetrieveTest()
        {
            //Arrange
            var Add = new Address(1000)
            {
                City = "Timbuktu"
            };
            var expected = "Timbuktu";


            //Act
            var actualAdd = Address.Retrieve(1000);

            //Assert
            Assert.AreEqual(expected, actualAdd.City);
        }

        [TestMethod()]
        public void RetrieveListTest()
        {
            //Arrange
            var a1 = new Address("Birmingham");
            var a2 = new Address("Chilham");
            var expected = "Birmingham Chilham ";

            //Act
            var addresses = Address.RetrieveList();
            var actual = "";
            foreach (Address address in addresses)
            {
                actual += address.City;
                actual += " ";
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateTestSuccess()
        {
            //Arrange
            var currentAdd = new Address(2000);
            currentAdd.City = "Maryland";
            var expected = true;

            //Act
            var actual = Address.Validate(currentAdd);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}