using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugDB.BL;


namespace BugDB.BLTest
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod]
        public void ValidateEmailPassTest()
        {
            //arrange
            var email = new Email("  bob@name.com  ");
            var expected = true;

            //act
            var actual = Email.Validate(email);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
