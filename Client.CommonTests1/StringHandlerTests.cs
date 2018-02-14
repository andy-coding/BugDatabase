using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Common.Test
{
    [TestClass()]
    public class StringHandlerTests
    {
        [TestMethod()]
        public void TidyTest()
        {
            //arrange
            var text = " HeLlO tHeRe! ";
            var expected = "Hello There!";

            //act
            var actual = StringHandler.Tidy(text);
            Console.WriteLine(actual);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}