using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ReziRoster.API.Context
{
    public class TeamRosterContext : DbContext
    {
        public TeamRosterContext(DbContextOptions<TeamRosterContext> options) : base(options)
        { }

        public DbSet<TeamRoster> TeamRoster { get; set; }
    }
}