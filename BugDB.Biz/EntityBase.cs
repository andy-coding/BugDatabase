using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugDB.BL
{
    public abstract class EntityBase
    {
        public bool IsNew { get;  set; }

        public bool HasChanges { get; private set; }

        public bool IsValid
        {
            get { return Validate(); }
        }

        public abstract bool Validate();
    }
}
