using HockeyManager;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    internal class AddDB
    {
        private static HockeyManagerDbContext db = new HockeyManagerDbContext();

        public static async Task AddTeamAsync(StreamReader reader)
        {
            IDbContextTransaction transaction = db.Database.BeginTransaction();
            try
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] properties = line.Split(',');
                    line = await reader.ReadLineAsync();
                    var res = await db.AddAsync(new Team {Name = properties[0], Conference = properties[1].Equals("1") ? true : false });
                    await db.SaveChangesAsync();
                }
                await transaction.CommitAsync();
            } 
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                MessageBox.Show("We can't add the team(s)" + ex.Message);
            }
        }

        public static async Task AddPlayersAsync(StreamReader reader)
        {
            var transaction = db.Database.BeginTransaction();
            try
            {
                string line = await reader.ReadLineAsync();
                List<Team> team = ReadDB.GetAllTeams();
                int teamCounter = 0;
                while (line != null)
                {
                    string[] properties = line.Split(",");
                    line = await reader.ReadLineAsync();
                    int statId = await AddStatsAsync();
                    int teamId = team[teamCounter % 23].TeamId;
                    teamCounter++;
                    await db.SaveChangesAsync();
                }
                await transaction.CommitAsync();
            }
            catch (Exception ex) 
            {
                await transaction.RollbackAsync();
                MessageBox.Show("We can´t add players.\n" + ex.Message);
            }
        }

        private static async Task<int> AddStatsAsync()
        {
            try
            {

                var stats = await db.AddAsync(new Stats {Goals = 0, Assists = 0, PlusMinus = 0});
                return stats.Entity.StatsId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.", ex.Message);
                return -1;
            }

        }
    }
}
