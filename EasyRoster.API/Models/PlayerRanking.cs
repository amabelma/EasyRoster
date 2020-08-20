using EasyRoster.API.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRoster.API.Models
{
    public class PlayerRanking
    {
        public PlayerRanking(
            Gender Gender,
            Height Height,
            LevelOfPlay HighestLevelPlayed,
            DateTime LastUpdated,
            double OverallRanking,
            Guid PlayerId,
            Position PreferredPosition,
            int YearsExperience
        )
        {
            this.Gender = Gender;
            this.Height = Height;
            this.HighestLevelPlayed = HighestLevelPlayed;
            this.LastUpdated = LastUpdated;
            this.OverallRanking = OverallRanking;
            this.PlayerId = PlayerId;
            this.PreferredPosition = PreferredPosition;
            this.YearsExperience = YearsExperience;
        }

        public Gender Gender { get; set; }
        public Height Height { get; set; }
        public LevelOfPlay HighestLevelPlayed { get; set; }
        public DateTime LastUpdated { get; set; }
        public double OverallRanking { get; set; }
        public Guid PlayerId { get; set; }
        public Position PreferredPosition { get; set; }
        public int YearsExperience { get; set; }
    }
}