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
    public class ReplicatorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveTest()
        {
            //Arrange
            var replicRepo = new ReplicatorRepository();
            var expected = new Replicator(1001)
            {
                Name = "Dave's Replcation Services"
            };

            //Act
            var actual = replicRepo.Retrieve(1001);

            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
        }
    }
}