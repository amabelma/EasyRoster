using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Domains
{
    public class TeamRosterDomain : ITeamRosterDomain
    {
        private TeamRosterRepository _repository;
        private DbContext _context;

        public TeamRosterDomain()
        {
            _repository = new TeamRosterRepository(_context);
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
