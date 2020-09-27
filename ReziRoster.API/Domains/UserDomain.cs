using ReziRoster.API.Context;
using ReziRoster.API.Domains.Interface;
using ReziRoster.API.Models;
using ReziRoster.API.Repositories;
using System.Threading.Tasks;

namespace ReziRoster.API.Domains
{
    public class UserDomain : IUserDomain
    {
        public UserDomain(UserContext context)
        {
            _context = context;
            _repository = new UserRepository(_context);
        }

        public void Delete(User entityToDelete)
        {
            _repository.Delete(entityToDelete);
        }

        public async Task<User> GetByID(object id)
        {
            return await _repository.GetByID(id);
        }

        //public User GetByName(string UserName)
        //{
            //Pass in WHERE clause as a lambda here
        //    List<User> _UsersWithName = _repository.Get( e => e.Name == UserName).ToList();
        //    return 
        //}

        public void Insert(User entity)
        {
            _repository.Insert(entity);
        }

        public void Update(User entityToUpdate)
        {
            _repository.Update(entityToUpdate);
        }

        private readonly UserContext _context;
        private readonly UserRepository _repository;
    }
}
