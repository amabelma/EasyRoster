using ReziRoster.API.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReziRoster.API.Models
{
    public class Team
    {
        public Team(
            bool Deleted,
            Guid EventId,
            Guid Id,
            DateTime LastUpdated,
            string Name
        )
        {
            this.Deleted        = Deleted;
            this.EventId        = EventId;
            this.Id             = Id;
            this.LastUpdated    = LastUpdated;
            this.Name           = Name;
        }

        public bool     Deleted { get; set; }
        public Guid     EventId { get; set; }
        public Guid     Id { get; set; }
        public DateTime LastUpdated { get; set; }
        public string   Name { get; set; }
    }
}