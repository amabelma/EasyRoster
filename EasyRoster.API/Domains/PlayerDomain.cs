using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EasyRoster.API.Domains
{
    public class PlayerDomain : IPlayerDomain
    {
        private PlayerRepository _repository;
        private DbContext _context;

        public PlayerDomain()
        {
            _repository = new PlayerRepository(_context);
        }

        public void Delete(Player entityToDelete)
        {
            _repository.Delete(entityToDelete);
        }

        public Player GetByID(object id)
        {
            return _repository.GetByID(id);
        }

        public List<Player> GetByName(string PlayerName)
        {
            //Pass in WHERE clause as a lambda here
            List<Player> _PlayersWithName = _repository.GetByCustomExpression(e => e.FirstName == PlayerName, null, "").ToList();
            return _PlayersWithName;
        }
        
        public void Insert(Player entity)
        {
            _repository.Insert(entity);
        }

        public void Update(Player entityToUpdate)
        {
            _repository.Update(entityToUpdate);
        }
    }
}
