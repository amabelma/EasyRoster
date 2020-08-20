using EasyRoster.API.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRoster.API.Models
{
    public class Event
    {
        public Event(
            bool Deleted,
            DraftStyle DraftStyle,
            DateTime EndDate,
            Guid Id,
            DateTime LastUpdated,
            string Name,
            Guid OrganizationID,
            DateTime StartDate
        )
        {
            this.Deleted = Deleted;
            this.DraftStyle = DraftStyle;
            this.EndDate = EndDate;
            this.Id = Id;
            this.LastUpdated = LastUpdated;
            this.Name = Name;
            this.OrganizationID = OrganizationID;
            this.StartDate = StartDate;
        }

        public bool Deleted { get; set; }
        public DraftStyle DraftStyle { get; set; }
        public DateTime EndDate { get; set; }
        public Guid Id { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Name { get; set; }
        public Guid OrganizationID { get; set; }
        public DateTime StartDate { get; set; }
    }
}