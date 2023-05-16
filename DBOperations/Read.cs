using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    internal class Read
    {
        private HockeyManagerDbContext db = new();
        public async Task<List<Team>> GetAllTeams()
        {
            return await db.Teams.Select(t => t).ToListAsync();
        }

        public async Task<List<Team>> GetTeamsByConferenceAsync(bool conference)
        {
            return await db.Teams.Where(t => t.Conference == conference).ToListAsync();
        }

        public async Task<List<Team>> GetTeamsByNameAsync(string name)
        {
            return await db.Teams.Where(t => t.Name == name).ToListAsync();
        }

        public async Task<List<Player>> GetPlayersByTeamAsync(int teamId)
        {
            return await db.Player.Where(p => p.TeamId == teamId).ToListAsync();
        }

        public async Task<List<Player>> GetPlayersByNameAsync(string name)
        {
            return await db.Player.Where(p => p.Name == name).ToListAsync();
        }
    }
}
