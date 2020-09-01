using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReziRoster.API.Models;

namespace ReziRoster.API.Domains.Interface
{
    public interface IOrganizationDomain
    {   
        void Delete(Organization entityToDelete);
        Organization GetByID(object id);
        void Insert(Organization entity);
        void Update(Organization entityToUpdate);
    }
}
