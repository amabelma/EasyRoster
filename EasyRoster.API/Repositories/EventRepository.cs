using EasyRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Repositories
{
    public class EventRepository : BaseRepository<Event>
    {
        public EventRepository(DbContext context) : base(context)
        {
        }
    }
}