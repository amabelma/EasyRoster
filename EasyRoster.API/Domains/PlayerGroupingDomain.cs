using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;

namespace EasyRoster.API.Domains
{
    public class PlayerGroupingDomain : IPlayerGroupingDomain
    {
        private PlayerGroupingRepository _repository;

        public PlayerGroupingDomain()
        {
            //I believe I need to pass in context here?
            _repository = new PlayerGroupingRepository();
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
