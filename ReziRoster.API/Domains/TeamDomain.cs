using ReziRoster.API.Context;
using ReziRoster.API.Domains.Interface;
using ReziRoster.API.Models;
using ReziRoster.API.Repositories;

namespace ReziRoster.API.Domains
{
    public class TeamDomain : ITeamDomain
    {
        public TeamDomain(TeamContext context)
        {
            _context = context;
            _repository = new TeamRepository(_context);
        }

        public void Delete(Team entityToDelete)
        {
            _repository.Delete(entityToDelete);
        }

        public Team GetByID(object id)
        {
            return _repository.GetByID(id);
        }

        //public Team GetByName(string TeamName)
        //{
            //Pass in WHERE clause as a lambda here
        //    List<Team> _TeamsWithName = _repository.Get( e => e.Name == TeamName).ToList();
        //    return 
        //}

        public void Insert(Team entity)
        {
            _repository.Insert(entity);
        }

        public void Update(Team entityToUpdate)
        {
            _repository.Update(entityToUpdate);
        }

        private readonly TeamContext _context;
        private readonly TeamRepository _repository;
    }
}
