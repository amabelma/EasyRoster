using EasyRoster.API.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRoster.API.Models
{
    public class Player
    {
        public Player(
            int id, 
            DateTime lastUpdated,
            string firstName,
            string lastName,
            string email,
            string phoneNumber,
            Gender gender,
            Height height,
            int yearsExperience,
            Position preferredPosition,
            LevelOfPlay highestLevelPlayed,
            VolunteerWillingness volunteerWillingness,
            LeadershipRole leadershipRole,
            List<Player> baggagedPlayers
        )
        {
            Id = id;
            LastUpdated = lastUpdated;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Gender = gender;
            Height = height;
            YearsExperience = yearsExperience;
            PreferredPosition = preferredPosition;
            HighestLevelPlayed = highestLevelPlayed;
            VolunteerWillingness = volunteerWillingness;
            LeadershipRole = leadershipRole;
            BaggagedPlayers = baggagedPlayers;

        }

        public int Id { get; }
        public DateTime LastUpdated { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public Height Height { get; set; }
        public int YearsExperience { get; set; }
        public Position PreferredPosition { get; set; }
        public LevelOfPlay HighestLevelPlayed { get; set; }
        public VolunteerWillingness VolunteerWillingness { get; set; }
        public LeadershipRole LeadershipRole { get; set; }
        public List<Player>? BaggagedPlayers { get; set; }
    }
}
