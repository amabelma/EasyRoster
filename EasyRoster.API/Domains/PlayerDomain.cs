using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;

namespace EasyRoster.API.Domains
{
    public class PlayerDomain : IPlayerDomain
    {
        private PlayerRepository _repository;

        public PlayerDomain()
        {
            //I believe I need to pass in context here?
            _repository = new PlayerRepository();
        }

        public void Delete(Player entityToDelete)
        {
            _repository.Delete(entityToDelete);
        }

        public Player GetByID(object id)
        {
            return _repository.GetByID(id);
        }

        //public Player GetByName(string PlayerName)
        //{
            //Pass in WHERE clause as a lambda here
        //    List<Player> _PlayersWithName = _repository.Get( e => e.Name == PlayerName).ToList();
        //    return 
        //}

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
