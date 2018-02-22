using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Common;

namespace BugDB.BL
{
    /// <summary>
    /// handles replicators who make dics for projects
    /// </summary>
    public class Replicator : EntityBase, ILoggable
    {
        #region ctors
        public Replicator()
        {

        }
        public Replicator(int id)
        {
            this.Id = id;
        }
        #endregion

        #region props
        private int id;

        public int Id { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Address Address { get; set; }
        #endregion

        #region methods

        public override bool Validate()
        {
            var isValid = true;


            return isValid;
        }

        public string Log()
        {
            return "Name: " + this.Name + ": Address: " + this.ToString();
        }

        #endregion
    }
}
