using EasyRoster.API.Interfaces;
using EasyRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Repositories
{
    public class EligiblePlayersRepository : BaseRepository<EligiblePlayers>
    {
        public EligiblePlayersRepository(DbContext context) : base(context)
        {
        }
    }
}