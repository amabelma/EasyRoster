using EasyRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Repositories
{
    public class PlayerGroupingRepository : BaseRepository<PlayerGrouping>
    { 
        public PlayerGroupingRepository(DbContext context) : base(context)
        {

        }
    }
}