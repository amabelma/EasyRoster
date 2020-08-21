using EasyRoster.API.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRoster.API.Models
{
    public class PlayerGrouping
    {
        public PlayerGrouping(
            bool Approved,
            Guid EventId,
            Guid GroupingId,
            Guid PlayerId
        )
        {
            this.Approved   = Approved;
            this.EventId    = EventId;
            this.GroupingId = GroupingId;
            this.PlayerId   = PlayerId;
        }
        
        public bool Approved { get; set; }
        public Guid EventId { get; set; }
        public Guid GroupingId { get; set; }
        public Guid PlayerId { get; set; }
    }
}