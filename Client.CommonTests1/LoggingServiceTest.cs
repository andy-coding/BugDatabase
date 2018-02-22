using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugDB.BL;


namespace Client.Common.Test
{
    [TestClass()]
    public class LoggingServiceTest
    {
        [TestMethod()]
        public void WriteToFileTest()
        {
            //Arrange
            var logs = new List<ILoggable>();

            var newproj = new Project(1, "project1", Project.Format.DVD);
            var newclient = new BugDB.BL.Client(2, "newclient");

            logs.Add(newproj as ILoggable);
            logs.Add(newclient as ILoggable);

            //Act
            LoggingService.WriteToFile(logs);

            //Assert
            //Assert.Fail();
        }
    }
}