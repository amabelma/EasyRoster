using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EasyRoster.API.Domains
{
    public class OrganizationDomain : IOrganizationDomain
    {
        private OrganizationRepository _repository;
        private DbContext _context;

        public OrganizationDomain()
        {
            _repository = new OrganizationRepository(_context);
        }

        public void Delete(Organization entityToDelete)
        {
            _repository.Delete(entityToDelete);
        }

        public Organization GetByID(object id)
        {
            return _repository.GetByID(id);
        }

        //public Organization GetByName(string OrganizationName)
        //{
            //Pass in WHERE clause as a lambda here
        //    List<Organization> _OrganizationsWithName = _repository.Get( e => e.Name == OrganizationName).ToList();
        //    return 
        //}

        public void Insert(Organization entity)
        {
            _repository.Insert(entity);
        }

        public void Update(Organization entityToUpdate)
        {
            _repository.Update(entityToUpdate);
        }
    }
}
