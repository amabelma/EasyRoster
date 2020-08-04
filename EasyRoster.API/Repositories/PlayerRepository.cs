using EasyRoster.API.Interfaces;
using EasyRoster.API.Models;
using System;
using System.Collections.Generic;

namespace EasyRoster.API.Repositories
{
    class PlayerRepository : IPlayerRepository
    {
        public void DeletePlayer(Guid playerId)
        {
            throw new System.NotImplementedException();
        }

        public Player GetPlayerById(Guid playerId)
        {
            throw new System.NotImplementedException();
        }

        public List<Player> GetPlayersByRosterId(Guid rosterId)
        {
            throw new System.NotImplementedException();
        }

        public List<Player> GetPlayersByTeamId(Guid teamId)
        {
            throw new System.NotImplementedException();
        }

        public void InsertPlayer(Player player)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePlayer(Player player)
        {
            throw new System.NotImplementedException();
        }
    }
}