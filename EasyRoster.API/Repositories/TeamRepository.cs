using EasyRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Repositories
{
    public class TeamRepository : BaseRepository<Team>
    { 
        public TeamRepository(DbContext context) : base(context)
        {

        }
    }
}