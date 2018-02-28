using System;
using System.Collections.Generic;
using BugDB.Data;
using BugDB.BL;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BugDB.BLTest
{
    [TestClass()]
    public class ProjectRepositoryTest
    {
        [TestMethod()]
        public void RetrieveProjectListByIdTest()
        {
            //arrange
            var repo = new ProjectRepository();
            var expectedTitles = "project1project2";
            var expectedClientIds = "12";
            var expectedProjectFormats = "BDDVD";

            //act
            var actual = repo.RetrieveProjectsById(3000);
            var actualTitles = "";
            var actualClientIds = "";
            string actualProjectFormats = "";
            foreach (Project project in actual)
            {
                actualTitles += project.Title;
                actualClientIds += project.ClientId.ToString();
                actualProjectFormats += project.ProjectFormat;
            }

            //assert
            Assert.AreEqual(expectedTitles, actualTitles);
            Assert.AreEqual(expectedClientIds, actualClientIds);
            Assert.AreEqual(expectedProjectFormats, actualProjectFormats);

        }

        [TestMethod]
        public void RetriveProjectSingle()
        {
            // arrange
            var proj = new ProjectRepository();
            var expected = new Project
            {
                Title = "UnitTests are Go",
                ClientId = 1000,
                ProjectFormat = Project.Format.BD
            };

            //act
            var actual = proj.Retrieve(100);

            //assert
            Assert.AreEqual(expected.Title, actual.Title);
            Assert.AreEqual(expected.ClientId, actual.ClientId);
            Assert.AreEqual(expected.ProjectFormat, actual.ProjectFormat);
        }
    }
}
