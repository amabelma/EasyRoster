using ReziRoster.API.Interfaces;
using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ReziRoster.API.Repositories
{
    public class EligiblePlayersRepository : BaseRepository<EligiblePlayers>
    {
        public EligiblePlayersRepository(DbContext context) : base(context)
        {
        }
    }
}