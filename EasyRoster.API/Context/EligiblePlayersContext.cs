using EasyRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Context
{
    public class EligiblePlayersContext : DbContext
    {
        public EligiblePlayersContext(DbContextOptions<EligiblePlayersContext> options) : base(options)
        { }

        public DbSet<EligiblePlayers> EligiblePlayers { get; set; }
    }
}