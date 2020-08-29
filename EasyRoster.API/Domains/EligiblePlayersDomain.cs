using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Domains
{
    public class EligiblePlayersDomain : IEligiblePlayersDomain
    {
        private EligiblePlayersRepository _repository;
        private DbContext _context;

        public EligiblePlayersDomain()
        {
            _repository = new EligiblePlayersRepository(_context);
        }

        public void Delete(EligiblePlayers entityToDelete)
        {
            _repository.Delete(entityToDelete);
        }

        public EligiblePlayers GetByID(object id)
        {
            return _repository.GetByID(id);
        }

        public void Insert(EligiblePlayers entity)
        {
            _repository.Insert(entity);
        }
        public void Update(EligiblePlayers entityToUpdate)
        {
            _repository.Update(entityToUpdate);
        }
    }
}
