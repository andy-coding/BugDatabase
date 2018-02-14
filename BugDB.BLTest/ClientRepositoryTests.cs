using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugDB.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugDB.BLTest
{
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