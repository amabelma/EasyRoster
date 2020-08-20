using EasyRoster.API.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRoster.API.Models
{
    public class TeamRoster
    {
        public TeamRoster(
            bool Deleted,
            DateTime LastUpdated,
            LeadershipRole LeadershipRole,
            Guid TeamId,
            Guid PlayerId,
            Position Position
        )
        {
            this.Deleted        = Deleted;
            this.LastUpdated    = LastUpdated;
            this.LeadershipRole = LeadershipRole;
            this.TeamId         = TeamId;
            this.PlayerId       = PlayerId;
            this.Position       = Position;
        }

        public bool             Deleted { get; set; }
        public DateTime         LastUpdated { get; set; }
        public LeadershipRole   LeadershipRole { get; set; }
        public Guid             TeamId { get; set; }
        public Guid             PlayerId { get; set; }
        public Position         Position { get; set; }
    }
}