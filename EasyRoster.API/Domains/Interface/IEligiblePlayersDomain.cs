using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReziRoster.API.Models;

namespace ReziRoster.API.Domains.Interface
{
    public interface IEligiblePlayersDomain
    {
        void Delete(EligiblePlayers entityToDelete);
        EligiblePlayers GetByID(object id);
        void Insert(EligiblePlayers entity);
        void Update(EligiblePlayers entityToUpdate);
    }
}
