using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Common;

namespace BugDB.BL
{
    public class Client : EntityBase, ILoggable

    {
        /// <summary>
        /// defines clients who will provide projects
        /// </summary>
        /// 
         #region contructors
  
        public Client(): this ("")
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public Client(int id) : this ("")
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Client(string name)
        {
            IsNew = true;
            this.name = name;
            AddressList = new List<Address>();

        }

        #endregion

        #region props


        public int Id { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) new ArgumentNullException();
                name = StringHandler.Tidy(value);
            }
        }

        public List<Address> AddressList { get; set; }


        public string ContactName { get; set; }

        #endregion

        #region methods
        /// <summary>
        /// checks whether required field Name is populated
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;

            return isValid;
        }

        public string Log()
        {
            return "Client: " + this.Name
                + " " + this.AddressList;
        }
        #endregion
    }
}
