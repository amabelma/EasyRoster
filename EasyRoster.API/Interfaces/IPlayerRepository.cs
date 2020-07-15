using EasyRoster.API.Models;
using System.Collections.Generic;

namespace EasyRoster.API.Interfaces
{
    interface IPlayerRepository
    {
        List<Player> GetPlayersByTeamId(int teamId);
        List<Player> GetPlayersByRosterId(int rosterId);
        Player GetPlayerById(int playerId);
        void InsertPlayer(Player player);
        void DeletePlayer(int playerId);
        void UpdatePlayer(Player player);
    }
}
