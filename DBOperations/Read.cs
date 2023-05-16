using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    internal static class Read
    {
        private static HockeyManagerDbContext db = new();
        public static List<Team> GetAllTeams()
        {
            return db.Teams.AsNoTracking().ToList();
        }

        public static async Task<List<Team>> GetTeamsByConferenceAsync(bool conference)
        {
            return await db.Teams.Where(t => t.Conference == conference).AsNoTracking().ToListAsync();
        }

        public static async Task<List<Team>> GetTeamsByNameAsync(string name)
        {
            return await db.Teams.Where(t => t.Name.SequenceEqual(name)).AsNoTracking().ToListAsync();
        }

        public static async Task<List<Player>> GetPlayersByTeamAsync(int teamId)
        {
            return await db.Player.Where(p => p.TeamId == teamId).AsNoTracking().ToListAsync();
        }
    }
}
