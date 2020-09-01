using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ReziRoster.API.Context
{
    public class PlayerRankingContext : DbContext
    {
        public PlayerRankingContext(DbContextOptions<PlayerRankingContext> options) : base(options)
        { }

        public DbSet<PlayerRanking> PlayerRanking { get; set; }
    }
}