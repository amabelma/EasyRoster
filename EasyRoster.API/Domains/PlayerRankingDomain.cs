using ReziRoster.API.Context;
using ReziRoster.API.Domains.Interface;
using ReziRoster.API.Models;
using ReziRoster.API.Repositories;

namespace ReziRoster.API.Domains
{
    public class PlayerRankingDomain : IPlayerRankingDomain
    {
        public PlayerRankingDomain(PlayerRankingContext context)
        {
            _context = context;
            _repository = new PlayerRankingRepository(_context);
        }

        public void Delete(PlayerRanking entityToDelete)
        {
            _repository.Delete(entityToDelete);
        }

        public PlayerRanking GetByID(object id)
        {
            return _repository.GetByID(id);
        }

        //public PlayerRanking GetByName(string PlayerRankingName)
        //{
            //Pass in WHERE clause as a lambda here
        //    List<PlayerRanking> _PlayerRankingsWithName = _repository.Get( e => e.Name == PlayerRankingName).ToList();
        //    return 
        //}

        public void Insert(PlayerRanking entity)
        {
            _repository.Insert(entity);
        }

        public void Update(PlayerRanking entityToUpdate)
        {
            _repository.Update(entityToUpdate);
        }

        private readonly PlayerRankingContext _context;
        private readonly PlayerRankingRepository _repository;
    }
}
