using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;

namespace EasyRoster.API.Domains
{
    public class EligiblePlayersDomain : IEligiblePlayersDomain
    {
        private EligiblePlayersRepository _repository;

        public EligiblePlayersDomain()
        {
            //I believe I need to pass in context here?
            _repository = new EligiblePlayersRepository();
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
