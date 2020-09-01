using ReziRoster.API.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReziRoster.API.Models
{
    public class Organization
    {
        public Organization(
            bool Deleted,
            Guid Id,
            DateTime LastUpdated,
            string MainContact_Email,
            string MainContact_FirstName, //Should MainContact be a LeadershipRole on the User instead?
            string MainContact_LastName,
            string Name
        )
        {
            this.Deleted                = Deleted;
            this.Id                     = Id;
            this.LastUpdated            = LastUpdated;
            this.MainContact_Email      = MainContact_Email;
            this.MainContact_FirstName  = MainContact_FirstName;
            this.MainContact_LastName   = MainContact_LastName;
            this.Name                   = Name;
        }

        public bool     Deleted { get; set; }
        public Guid     Id { get; set; }
        public DateTime LastUpdated { get; set; }
        public string   MainContact_Email { get; set; }
        public string   MainContact_FirstName { get; set; }
        public string   MainContact_LastName { get; set; }
        public string   Name { get; set; }
    }
}