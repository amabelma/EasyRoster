using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Models;

namespace EasyRoster.API.Domains.Interface
{
    public interface IPlayerDomain
    {
        void Delete(Player entityToDelete);
        Player GetByID(object id);
        void Insert(Player entity);
        void Update(Player entityToUpdate);
    }
}
