using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Models;

namespace EasyRoster.API.Domains.Interface
{
    public interface IPlayerGroupingDomain
    {
        void Delete(PlayerGrouping entityToDelete);
        PlayerGrouping GetByID(object id);
        void Insert(PlayerGrouping entity);
        void Update(PlayerGrouping entityToUpdate);
    }
}
