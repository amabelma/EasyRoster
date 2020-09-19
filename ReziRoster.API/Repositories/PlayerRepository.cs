using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ReziRoster.API.Repositories
{
    public class PlayerRepository : BaseRepository<Player>
    { 
        public PlayerRepository(DbContext context) : base(context)
        {

        }
    }
}