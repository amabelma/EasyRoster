using EasyRoster.API.Enums;
using EasyRoster.API.Interfaces;
using EasyRoster.API.Models;
using System;
using System.Collections.Generic;

namespace EasyRoster.API.Repositories.MockRepositories
{
    class MockPlayerRepository : IPlayerRepository
    {
        public void DeletePlayer(Guid playerId)
        {
            if (_playerList.FindAll(p => p.Id == playerId).Count == 1)
			{
                // Do nothing because this is a mock repository
			}
            else
			{
                throw new ArgumentException("Player to be deleted not found in mock data.");
			}
        }

        public Player GetPlayerById(Guid playerId)
        {
            return _playerList.Find(p => p.Id == playerId);
        }

        public void InsertPlayer(Player player)
        {
            if (_playerList.FindAll(p => p.Id == player.Id).Count == 0)
            {
                // Do nothing because this is a mock repository
            }
            else
            {
                throw new ArgumentException("Player with provided Id already exists in mock data.");
            }
        }

        public void UpdatePlayer(Player player)
        {
            if (_playerList.FindAll(p => p.Id == player.Id).Count == 1)
            {
                // Do nothing because this is a mock repository
            }
            else
            {
                throw new ArgumentException("Player to be updated not found in mock data.");
            }
        }

        private List<Player> _playerList = new List<Player>() {
            
        };
    }
}