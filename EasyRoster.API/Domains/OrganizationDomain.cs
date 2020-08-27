using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Domains.Interface;
using EasyRoster.API.Models;
using EasyRoster.API.Repositories;

namespace EasyRoster.API.Domains
{
    public class OrganizationDomain : IOrganizationDomain
    {
        private OrganizationRepository _repository;

        public OrganizationDomain()
        {
            //I believe I need to pass in context here?
            _repository = new OrganizationRepository();
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
