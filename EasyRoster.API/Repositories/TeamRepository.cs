using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ReziRoster.API.Repositories
{
    public class TeamRepository : BaseRepository<Team>
    { 
        public TeamRepository(DbContext context) : base(context)
        {

        }
    }
}