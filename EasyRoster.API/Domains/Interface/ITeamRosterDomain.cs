using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Models;

namespace EasyRoster.API.Domains.Interface
{
    public interface ITeamRosterDomain
    {
        void Delete(TeamRoster entityToDelete);
        TeamRoster GetByID(object id);
        void Insert(TeamRoster entity);
        void Update(TeamRoster entityToUpdate);
    }
}
