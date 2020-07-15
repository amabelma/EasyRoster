using System.Collections.Generic;

namespace EasyRoster.API.Models
{
    public class Roster
    {
        public int Id { get; }
        public string RosterName { get; set; }
        public List<Team> Teams { get; set; }
        public List<Player> Players { get; set; }
        public List<Player> Captains { get; set; }
    }
}
