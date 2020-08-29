using EasyRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Repositories
{
    public class PlayerRankingRepository : BaseRepository<PlayerRanking>
    { 
        public PlayerRankingRepository(DbContext context) : base(context)
        {

        }
    }
}