using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Common;

namespace BugDB.BL
{
    /// <summary>
    /// Used to define and validate addresses
    /// </summary>
    public class Address : EntityBase, ILoggable
    {
        #region ctor

        public Address()
        {

        }
        public Address(string city)
        {
            Count++;
            this.Id = Count;
            this.City = city;
        }

        public Address(int id)
        {
            this.Id = id;
        }
        #endregion

        #region props
        private static int Count { get; set; } = 0;


        public int Id { get; set; }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public enum addressType{
            Delivery,
            Billing
        }

        public addressType Type { get; set; }






        #endregion

        #region methods

        /// <summary>
        /// confirms that address has valid Id and city fields
        /// </summary>
        /// <returns>bool val</returns>
        public override bool Validate()
        {
            var val = true;

            if ((this.Id < 0) || (string.IsNullOrWhiteSpace(this.City))) val = false;

            return val;
        }

        public string Log()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
