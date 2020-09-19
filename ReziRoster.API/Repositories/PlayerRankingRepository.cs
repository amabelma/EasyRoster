using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ReziRoster.API.Repositories
{
    public class PlayerRankingRepository : BaseRepository<PlayerRanking>
    { 
        public PlayerRankingRepository(DbContext context) : base(context)
        {

        }
    }
}