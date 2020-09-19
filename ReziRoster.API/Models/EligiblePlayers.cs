using ReziRoster.API.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReziRoster.API.Models
{
    public class EligiblePlayers
    {
        public EligiblePlayers(
            Guid PlayerGroupingID,
            Guid EventId,
            bool HasBeenSelected,
            DateTime LastUpdated,
            LeadershipRole LeadershipRole,
            Guid OrganizationID,
            Guid PlayerId,
            Position PreferredPosition
        )
        {
            this.PlayerGroupingID     = PlayerGroupingID;
            this.EventId            = EventId;
            this.HasBeenSelected    = HasBeenSelected;
            this.LastUpdated        = LastUpdated;
            this.LeadershipRole     = LeadershipRole;
            this.OrganizationID     = OrganizationID;
            this.PlayerId           = PlayerId;
            this.PreferredPosition  = PreferredPosition;
        }
        
        public Guid             PlayerGroupingID { get; set; }
        public Guid             EventId { get; set; }
        public bool             HasBeenSelected { get; set; }
        public DateTime         LastUpdated { get; set; }
        public LeadershipRole   LeadershipRole { get; set; }
        public Guid             OrganizationID { get; set; }
        public Guid             PlayerId { get; set; }
        public Position         PreferredPosition { get; set; }
    }
}