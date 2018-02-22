using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugDB.BL
{
    public class AddressRepository
    {
        public Address RetrieveAddress(int id)
        {
            var returnAddress = new Address(id);

            // temp hard-coded data to run test
            if (id == 1000)
            {
                returnAddress.City = "Timbuktu";
            }
            return returnAddress;
        }

        public List<Address> RetrieveByCustomerId(int customerId)
        {
            var AddressList = new List<Address>();

            // code required to retrieve all addresses for a given customer from the database


            // temp hardcoded data to test method
            if (customerId == 3000)
            {
                Address address1 = new Address()
                {
                    City = "Bognor",
                    Type = Address.AddressType.Billing
                };
            Address address2 = new Address()
            {
                City = "Arbroath",
                Type = Address.AddressType.Delivery
                };
                AddressList.Add(address1);
                AddressList.Add(address2);
            }

            return AddressList;
        } //end method

        public bool Save(Address address)
        {
            return true;
        }


    }
}
