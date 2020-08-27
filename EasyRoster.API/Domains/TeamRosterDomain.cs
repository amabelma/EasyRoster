using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;

namespace EasyRoster.API.Domains
{
    public class TeamRosterDomain : ITeamRosterDomain
    {
        private TeamRosterRepository _repository;

        public TeamRosterDomain()
        {
            //I believe I need to pass in context here?
            _repository = new TeamRosterRepository();
        }

        public void Delete(TeamRoster entityToDelete)
        {
            _repository.Delete(entityToDelete);
        }

        public TeamRoster GetByID(object id)
        {
            return _repository.GetByID(id);
        }

        //public TeamRoster GetByName(string TeamRosterName)
        //{
            //Pass in WHERE clause as a lambda here
        //    List<TeamRoster> _TeamRostersWithName = _repository.Get( e => e.Name == TeamRosterName).ToList();
        //    return 
        //}

        public void Insert(TeamRoster entity)
        {
            _repository.Insert(entity);
        }

        public void Update(TeamRoster entityToUpdate)
        {
            _repository.Update(entityToUpdate);
        }
    }
}
