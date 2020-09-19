using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ReziRoster.API.Repositories
{
    public class UserRepository : BaseRepository<User>
    { 
        public UserRepository(DbContext context) : base(context)
        {

        }
    }
}