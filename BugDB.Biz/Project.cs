using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.Common;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BugDB.BL
{
    /// <summary>
    /// defines project information
    /// </summary>
    public class Project : EntityBase, ILoggable
       {
            #region ctors

        public Project() : this(0, "", Format.unknown)
        { }

        public Project( int clientId, string title, Format format )
        {
            this.Title = title;
            this.ClientId = clientId;
            this.ProjectFormat = format;
        }
        #endregion



        #region props
        public enum Format
        {
            DVD,
            BD,
            unknown
        };

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int ClientId { get; set; }
        public Format ProjectFormat { get; set; }
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
            var logString = "ProjectID: " + this.Id
                + "ClientID: " + this.ClientId
                + "" + this.ProjectFormat ;

                return logString;
        }

        #endregion

    }
}
