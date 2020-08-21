using EasyRoster.API.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRoster.API.Models
{
    public class User
    {
        public User(
            bool        Deleted,
            string      Email,
            string      FirstName,
            Guid        Id,
            string      LastName,
            DateTime    LastUpdated,
            Guid        OrganizationId,
            string      Password,
            string      UserName
        )
        {
            this.Deleted        = Deleted;
            this.EventId        = EventId;
            this.Id             = Id;
            this.LastUpdated    = LastUpdated;
            this.Name           = Name;
        }

        public bool     Deleted { get; set; }
        public string   Email { get; set; }
        public string   FirstName { get; set; }
        public Guid     Id { get; set; }
        public string   LastName { get; set; }
        public DateTime LastUpdated { get; set; }
        public Guid     OrganizationId { get; set; }
        public string   Password { get; set; }
        public string   UserName { get; set; }
    }
}