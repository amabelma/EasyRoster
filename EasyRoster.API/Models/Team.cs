using EasyRoster.API.Enums;
using System.Collections.Generic;

namespace EasyRoster.API.Models
{
    public class Team
    {
        public int Id { get; }
        public string Name { get; set; }
        public TeamColor TeamColor { get; set; }
        public List<Player> Players { get; set; }
        public Player Captain { get; set; }
    }
}
