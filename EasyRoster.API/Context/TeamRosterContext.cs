using EasyRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Context
{
    public class TeamRosterContext : DbContext
    {
        public TeamRosterContext(DbContextOptions<TeamRosterContext> options) : base(options)
        { }

        public DbSet<TeamRoster> TeamRoster { get; set; }
    }
}