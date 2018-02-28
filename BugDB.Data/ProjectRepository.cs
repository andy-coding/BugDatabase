using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugDB.BL
{
    public class ProjectRepository
    {
        public ProjectRepository()
        {
        }

        public Project Retrieve(int projectId)
        {
            var returnproj = new Project();
            // code required to obtain data from db

            //temp hard code to test method
            if (projectId == 100)
            {
                var project1 = new Project
                {
                    Title = "UnitTests are Go",
                    ClientId = 1000,
                    ProjectFormat = Project.Format.BD
                };
                returnproj = project1;
            }
            return returnproj;
        }

        public List<Project> RetrieveProjectsById(int projectId)
        {
            var projectList = new List<Project>();

            // code required to retrieve projects from database

            //temp hard code to unit test method
            if (projectId == 3000)
            {
                var proj1 = new Project()
                {
                    Title = "project1",
                    ClientId = 1,
                    ProjectFormat = Project.Format.BD
                };
                var proj2 = new Project()
                {
                    Title = "project2",
                    ClientId = 2,
                    ProjectFormat = Project.Format.DVD
                };

                projectList.Add(proj1);
                projectList.Add(proj2);
            }
            //end hard code

            return projectList;
        }
    }
}
