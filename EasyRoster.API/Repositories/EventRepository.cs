using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ReziRoster.API.Repositories
{
    public class EventRepository : BaseRepository<Event>
    {
        public EventRepository(DbContext context) : base(context)
        {
        }
    }
}