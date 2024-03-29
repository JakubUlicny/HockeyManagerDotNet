﻿using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HockeyManager
{
    internal class Delete
    {
        private static HockeyManagerDbContext db = new HockeyManagerDbContext();

        public async Task<bool> DeletePlayerByNameAsync(Player player)
        {
            var transaction = db.Database.BeginTransaction();
            try
            {
                db.Player.RemoveRange(db.Player.Where(p => p.Name.SequenceEqual(player.Name)));
                await db.SaveChangesAsync();
                await DeleteStatsAsync(new List<Player>() { player });
                await db.SaveChangesAsync();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<int> DeleteTeamAsync(Team? team)
        {
            var transaction = db.Database.BeginTransaction();
            try
            {
                int deletedPlayers, deletedStats;
                if (team != null)
                {
                    int teamId = team.TeamId;
                    db.Teams.RemoveRange(db.Teams.Where(t => t.TeamId == teamId));
                    await db.SaveChangesAsync();
                    deletedPlayers = await DeletePlayersByTeamAsync(teamId);
                    List<Player> players = await new Read().GetPlayersByTeamAsync(teamId);
                    deletedStats = await DeleteStatsAsync(players);
                    if (deletedStats != deletedPlayers)
                    {
                        throw new NotMatchingStatsAndPlayersException(deletedPlayers, deletedStats);
                    }
                    transaction.Commit();
                    return 1;
                }
                int counter = 0;
                foreach (Team item in db.Teams)
                {
                    db.Teams.Remove(item);
                    await db.SaveChangesAsync();
                    counter++;
                }
                deletedPlayers = await DeleteTeamPlayersAsync();
                deletedStats = await DeleteAllStatsAsync();
                
                if (deletedStats != deletedPlayers)
                {
                    throw new NotMatchingStatsAndPlayersException(deletedPlayers, deletedStats);
                }
                transaction.Commit();
                return counter;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw;
            }
            
            
        }

        private async Task<int> DeleteTeamPlayersAsync()
        {
            int counter = 0;
            foreach (Player item in db.Player)
            {
                db.Player.Remove(item);
                await db.SaveChangesAsync();
                counter++;
            }
            return counter;
        }

        public async Task<int> DeleteAllPlayersAsync()
        {
            var transaction = db.Database.BeginTransaction();
            try 
            {
                int counter = 0;
                foreach (Player item in db.Player)
                {
                    db.Player.Remove(item);
                    await db.SaveChangesAsync();
                    counter++;
                }
                transaction.Commit();
                return counter;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw;
            }
        }

        private async Task<int> DeletePlayersByTeamAsync(int teamId)
        {
            var toDelete = db.Player.Where(p => p.TeamId == teamId);
            db.Player.RemoveRange(toDelete);
            await db.SaveChangesAsync();
            return toDelete.Count();
        }

        private async Task<int> DeleteStatsAsync(List<Player> players)
        {
            int count = players.Count();
            foreach (int item in players.Select(p => p.StatsId))
            {
                db.Stats.RemoveRange(db.Stats.Where(s => s.StatsId == item));
                await db.SaveChangesAsync();
            }
            return count;
        }

        private async Task<int> DeleteAllStatsAsync()
        {
            int count = db.Stats.Count();
            db.Stats.RemoveRange(db.Stats);
            await db.SaveChangesAsync();
            return count;
        }

    }
}
