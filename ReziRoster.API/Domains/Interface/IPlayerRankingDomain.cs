using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReziRoster.API.Models;

namespace ReziRoster.API.Domains.Interface
{
    public interface IPlayerRankingDomain
    {
        void Delete(PlayerRanking entityToDelete);
        PlayerRanking GetByID(object id);
        void Insert(PlayerRanking entity);
        void Update(PlayerRanking entityToUpdate);
    }
}
