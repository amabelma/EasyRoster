using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Domains
{
    public class PlayerGroupingDomain : IPlayerGroupingDomain
    {
        private PlayerGroupingRepository _repository;
        private DbContext _context;

        public PlayerGroupingDomain()
        {
            _repository = new PlayerGroupingRepository(_context);
        }

        public void Delete(PlayerGrouping entityToDelete)
        {
            _repository.Delete(entityToDelete);
        }

        public PlayerGrouping GetByID(object id)
        {
            return _repository.GetByID(id);
        }

        //public PlayerGrouping GetByName(string PlayerGroupingName)
        //{
            //Pass in WHERE clause as a lambda here
        //    List<PlayerGrouping> _PlayerGroupingsWithName = _repository.Get( e => e.Name == PlayerGroupingName).ToList();
        //    return 
        //}

        public void Insert(PlayerGrouping entity)
        {
            _repository.Insert(entity);
        }

        public void Update(PlayerGrouping entityToUpdate)
        {
            _repository.Update(entityToUpdate);
        }
    }
}
