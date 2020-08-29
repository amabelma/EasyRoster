using EasyRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Repositories
{
    public class PlayerRepository : BaseRepository<Player>
    { 
        public PlayerRepository(DbContext context) : base(context)
        {

        }
    }
}