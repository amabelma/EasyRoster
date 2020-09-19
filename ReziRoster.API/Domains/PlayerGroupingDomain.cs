using ReziRoster.API.Context;
using ReziRoster.API.Domains.Interface;
using ReziRoster.API.Models;
using ReziRoster.API.Repositories;

namespace ReziRoster.API.Domains
{
    public class PlayerGroupingDomain : IPlayerGroupingDomain
    {
        public PlayerGroupingDomain(PlayerGroupingContext context)
        {
            _context = context;
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

        private readonly PlayerGroupingContext _context;
        private readonly PlayerGroupingRepository _repository;
    }
}
