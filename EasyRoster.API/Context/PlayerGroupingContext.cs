using EasyRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Context
{
    public class PlayerGroupingContext : DbContext
    {
        public PlayerGroupingContext(DbContextOptions<PlayerGroupingContext> options) : base(options)
        { }

        public DbSet<PlayerGrouping> PlayerGrouping { get; set; }
    }
}