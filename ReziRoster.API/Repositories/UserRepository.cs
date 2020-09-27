using ReziRoster.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ReziRoster.API.Repositories
{
    public class UserRepository : BaseRepository<User>
    { 
        public UserRepository(DbContext context) : base(context)
        {

        }
    }
}