using System;

namespace EasyRoster.API.Models
{
    public class User
    {
        public User(
            string Email,
            string FirstName,
            string LastName,
            string Password,
            string UserName
        )
        {
            this.Email = Email;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Password = Password;
            this.UserName = UserName;
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