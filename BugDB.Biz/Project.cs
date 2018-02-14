using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.Common;
using System.Threading.Tasks;

namespace BugDB.BL
{
    /// <summary>
    /// defines project information
    /// </summary>
    public class Project : EntityBase, ILoggable
       {
            #region ctors

        public Project() : this(0, "", format.unknown)
        { }

        public Project( int clientId, string title, format format )
        {
            this.Title = title;
            this.ClientId = clientId;
            this.ProjectFormat = format;
        }
        #endregion



        #region props
        public enum format
        {
            DVD,
            BD,
            unknown
        };

        public static int Id { get; set; } = 0;
        public string Title { get; set; }
        public int ClientId { get; set; }
        public format ProjectFormat { get; set; }
        #endregion

        #region methods
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Title)) isValid = false;
            return isValid;
        }

        public void Log()
        {
            var logString = Id + " " + this.Title + " " +
                                ClientId + " " + ProjectFormat;
            
        }

        string ILoggable.Log()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
