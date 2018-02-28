using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugDB.BL
{
    public class ReplicatorRepository
    {
        public ReplicatorRepository()
        {

        }

        public Replicator Retrieve(int replicatorId)
        {
            var replicator = new Replicator();

            // get data from DB - TBC

            //temp hard-coded data to check method:
            if (replicatorId == 1001)
            {
                replicator.Name = "Dave's Replcation Services";
            }

            return replicator;
        }
    }
}
