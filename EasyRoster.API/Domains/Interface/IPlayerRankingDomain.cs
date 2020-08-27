using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRoster.API.Models;

namespace EasyRoster.API.Domains.Interface
{
    public interface IPlayerRankingDomain
    {
        void Delete(PlayerRanking entityToDelete);
        PlayerRanking GetByID(object id);
        void Insert(PlayerRanking entity);
        void Update(PlayerRanking entityToUpdate);
    }
}
