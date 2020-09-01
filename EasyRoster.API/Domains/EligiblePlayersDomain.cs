using EasyRoster.API.Context;
using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;

namespace EasyRoster.API.Domains
{
    public class EligiblePlayersDomain : IEligiblePlayersDomain
    {
        public EligiblePlayersDomain(EligiblePlayersContext context)
        {
            _context = context;
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

        private readonly EligiblePlayersContext _context;
        private readonly EligiblePlayersRepository _repository;
    }
}
