using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ReziRoster.API.Repositories
{
    public class PlayerGroupingRepository : BaseRepository<PlayerGrouping>
    { 
        public PlayerGroupingRepository(DbContext context) : base(context)
        {

        }
    }
}