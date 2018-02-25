using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugDB.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugDB.Data.Test
{
    [TestClass()]
    public class ClientRepositoryTests
    {
        [TestMethod()]
        public void ClientSaveTest()
        {
            //arrange
            var expected = new Client();
            expected.Id = 0;
            expected.Name = "Bob";

            //act
            var clientRepo = new ClientRepository();
            var actual = new Client { Id = 0, Name = "Bob" };
            clientRepo.Save(actual);
            Console.WriteLine(actual.Id);
            Console.WriteLine(actual.Name);

            //assert
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Name, actual.Name);
        }
    }

    [TestClass()]
    public class ClientRepositoryTest
    {
        [TestMethod()]
        public void RetrieveClientTest()
        {
            //Arrange
            var c1repo = new ClientRepository();
            var expected = new Client(101)
            {
                Name = "Bob's Testing Co"                
            };

            //Act
            Client c1 = c1repo.Retrieve(101);
            var actual = c1;

            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
        }
    }
}