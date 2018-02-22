using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugDB.BL
{
    public class Email
    {

        #region ctor
        public Email(string emailString)
        {
            this.Address = emailString;
            Count++;
            this.Id = Count;
        }
        #endregion

        #region props
        public static int Count { get; private set; } = 0;

        public int Id { get; set; }

        private string address;

        public string Address
        {
            get { return address; }
        
            set
            {
                if (value.Contains("@") && value.Contains("."))
                {
                    address = value.Trim();
                }
                else address = "";
            }          
        }
        #endregion

        public static bool Validate(Email emailAddress)
        {
            var status = true;

            if (string.IsNullOrWhiteSpace(emailAddress.address)) status = false;

            return status;
        }
    }
}
