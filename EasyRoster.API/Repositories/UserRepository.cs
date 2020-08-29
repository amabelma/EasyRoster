using EasyRoster.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Repositories
{
    public class UserRepository : BaseRepository<User>
    { 
        public UserRepository(DbContext context) : base(context)
        {

        }
    }
}