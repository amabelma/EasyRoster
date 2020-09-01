using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ReziRoster.API.Repositories
{
    public class TeamRosterRepository : BaseRepository<TeamRoster>
    { 
        public TeamRosterRepository(DbContext context) : base(context)
        {

        }
    }
}