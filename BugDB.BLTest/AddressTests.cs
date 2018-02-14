using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugDB.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugDB.BL.Test
{
    [TestClass()]
    public class AddressTests
    {
        [TestMethod()]
        public void RetrieveAddressTest()
        {
            //Arrange
            var AddRepo = new AddressRepository();
            var expected = new Address(1000)
            { City = "Timbuktu"};

            //Act
            var actual = AddRepo.RetrieveAddress(1000);

            //Assert
            Assert.AreEqual(expected.City, actual.City);
        }

        [TestMethod()]
        public void RetrieveAddressListTest()
        {
            //Arrange
            var AddRepo = new AddressRepository();
            var expectedCity = "Bognor Arbroath ";
            var expectedType = "Billing Delivery ";

            //Act
            var addresses = AddRepo.RetrieveByCustomerId(3000);
       //     Console.WriteLine(addresses.Count);
            var actualCity = "";
            var actualType = "";
            foreach (Address address in addresses)
            {
                actualCity += address.City;
                Console.WriteLine("actualCity = " + address.City);
                actualCity += " ";
                actualType += address.Type;
                Console.WriteLine("actualType = " + address.Type);
                actualType += " ";
            }

            //Assert
            Assert.AreEqual(expectedCity, actualCity);
            Assert.AreEqual(expectedType, actualType);

        }

        [TestMethod()]
        public void ValidateTestSuccess()
        {
            //Arrange
            var currentAdd = new Address(2000)
            {
                City = "Maryland"
            };

            var expected = true;

            //Act
            var actual = currentAdd.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}