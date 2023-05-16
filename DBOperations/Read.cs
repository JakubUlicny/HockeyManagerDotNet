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
        public List<Team> GetAllTeams()
        {
            return db.Teams.AsNoTracking().ToList();
        }

        public async Task<List<Team>> GetTeamsByConferenceAsync(bool conference)
        {
            return await db.Teams.Where(t => t.Conference == conference).AsNoTracking().ToListAsync();
        }

        public async Task<List<Team>> GetTeamsByNameAsync(string name)
        {
            return await db.Teams.Where(t => t.Name.SequenceEqual(name)).AsNoTracking().ToListAsync();
        }

        public async Task<List<Player>> GetPlayersByTeamAsync(int teamId)
        {
            return await db.Player.Where(p => p.TeamId == teamId).AsNoTracking().ToListAsync();
        }

        public async Task<List<Player>> GetPlayersByNameAsync(string name)
        {
            return await db.Player.Where(p => p.Name.SequenceEqual("name")).AsNoTracking().ToListAsync();
        }
    }
}
