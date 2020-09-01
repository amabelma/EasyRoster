using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ReziRoster.API.Context
{
    public class EligiblePlayersContext : DbContext
    {
        public EligiblePlayersContext(DbContextOptions<EligiblePlayersContext> options) : base(options)
        { }

        public DbSet<EligiblePlayers> EligiblePlayers { get; set; }
    }
}