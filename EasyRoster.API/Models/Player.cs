using EasyRoster.API.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyRoster.API.Models
{
    public class Player
    {
        public Player(
            DateTime Birthday,
            string Email,
            string FirstName,
            Gender Gender, 
            Height Height, 
            Guid Id,
            string LastName,
            DateTime LastUpdated,
            Guid OrganizationId,
            string PhoneNumber,
            Position PreferredPosition,
            VolunteerWillingness VolunteerWillingness
        )
        {
            this.Birthday               = Birthday;
            this.Email                  = Email;
            this.FirstName              = FirstName;
            this.Gender                 = Gender;
            this.Height                 = Height;
            this.Id                     = Id;
            this.LastName               = LastName;
            this.LastUpdated            = LastUpdated;
            this.OrganizationId         = OrganizationId;
            this.PhoneNumber            = PhoneNumber;
            this.PreferredPosition      = PreferredPosition;
            this.VolunteerWillingness   = VolunteerWillingness;
        }

        public DateTime             Birthday { get; set; }
        public string               Email { get; set; }
        public string               FirstName { get; set; }
        public Gender               Gender { get; set; } 
        public Height               Height { get; set; } 
        public Guid                 Id { get; set; }
        public string               LastName { get; set; }
        public DateTime             LastUpdated { get; set; }
        public Guid                 OrganizationId { get; set; }
        public string               PhoneNumber { get; set; }
        public Position             PreferredPosition { get; set; }
        public VolunteerWillingness VolunteerWillingness { get; set; }
    }
}