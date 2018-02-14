using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugDB.BL
{
    public class ClientRepository
    {
        public ClientRepository()
        {
        }

        #region methods

        /// <summary>
        /// retrieves a single client
        /// </summary>
        /// <returns>bool</returns>   

        public Client Retrieve(int clientId)
        {
            //create instance of classes
            var client = new Client(clientId);
            var address = new Address();

            //retrieve code from database - TBC

            // temp code:
            if (clientId == 101)
            {
                client.Name = "Bob's testing co";
                address = new Address("L" +
                    "Louisville");
                client.AddressList.Add(address);
            }

            return client;
        }

        public bool Save()
        {
            //  code is to be added here

            return true;
        }
        #endregion
    }
}
