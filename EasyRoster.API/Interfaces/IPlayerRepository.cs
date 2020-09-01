using ReziRoster.API.Models;
using System;
using System.Collections.Generic;

namespace ReziRoster.API.Interfaces
{
    interface IPlayerRepository
    {
        Player GetPlayerById(Guid playerId);
        void InsertPlayer(Player player);
        void DeletePlayer(Guid playerId);
        void UpdatePlayer(Player player);
    }
}