using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;

namespace EasyRoster.API.Domains
{
    public class UserDomain : IUserDomain
    {
        private UserRepository _repository;

        public UserDomain()
        {
            //I believe I need to pass in context here?
            _repository = new UserRepository();
        }

        public void Delete(User entityToDelete)
        {
            _repository.Delete(entityToDelete);
        }

        public User GetByID(object id)
        {
            return _repository.GetByID(id);
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
    }
}
