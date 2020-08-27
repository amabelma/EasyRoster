using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Models;

namespace EasyRoster.API.Domains.Interface
{
    public interface ITeamDomain
    {
        void Delete(Team entityToDelete);
        Team GetByID(object id);
        void Insert(Team entity);
        void Update(Team entityToUpdate);
    }
}
