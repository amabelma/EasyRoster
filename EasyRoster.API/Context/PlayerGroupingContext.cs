using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ReziRoster.API.Context
{
    public class PlayerGroupingContext : DbContext
    {
        public PlayerGroupingContext(DbContextOptions<PlayerGroupingContext> options) : base(options)
        { }

        public DbSet<PlayerGrouping> PlayerGrouping { get; set; }
    }
}