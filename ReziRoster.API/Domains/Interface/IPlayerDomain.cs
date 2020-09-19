using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReziRoster.API.Models;

namespace ReziRoster.API.Domains.Interface
{
    public interface IPlayerDomain
    {
        void Delete(Player entityToDelete);
        Player GetByID(object id);
        void Insert(Player entity);
        void Update(Player entityToUpdate);
    }
}
