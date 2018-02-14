using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugDB.BL;

namespace BugDB.BLTest
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void ClientCountTest()
        {
            //Arrange
            Client.Count = 0;
            var c1 = new Client();
            var c2 = new Client();
            var expected = 2;

            //Act

            //Assert
            Assert.AreEqual(expected, Client.Count);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            Client currentClient = new Client()
            {
                Name = " Client1! "
            };
            var expected = true;

            //Act
            var actual = currentClient.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine("client ID = {0}", currentClient.Id);
        }

        [TestMethod]
        public void ValidateClientInvalid()
        {
            //Arrange
            Client currentClient = new Client(2003);
            var expected = false;

            //Act
            var actual = currentClient.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
