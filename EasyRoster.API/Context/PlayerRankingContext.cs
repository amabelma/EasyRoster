using EasyRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Context
{
    public class PlayerRankingContext : DbContext
    {
        public PlayerRankingContext(DbContextOptions<PlayerRankingContext> options) : base(options)
        { }

        public DbSet<PlayerRanking> PlayerRanking { get; set; }
    }
}