using EasyRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Repositories
{
    public class TeamRosterRepository : BaseRepository<TeamRoster>
    { 
        public TeamRosterRepository(DbContext context) : base(context)
        {

        }
    }
}