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
    internal class Create
    {
        private static HockeyManagerDbContext db = new HockeyManagerDbContext();
        private static Position position;

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
                    if (properties.Length != 2)
                    {
                        throw new WrongFormatException();
                    }
                    await db.AddAsync(new Team {Name = properties[0], Conference = properties[1].Equals("1") ? true : false });
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

        private static void CheckProperties(string[] properties)
        {
            if (properties.Length != 3)
            {
                throw new WrongFormatException();
            }
        }

        private static async Task CreateDBValues(string[] properties, int teamId)
        {
            int statsId = await AddStatsAsync();
            if (!Enum.TryParse<Position>(properties[1], true, out position))
            {
                throw new WrongPositionFormatException(properties[1]);
            }

            await db.AddAsync(new Player { Name = properties[0], Position = position, Age = int.Parse(properties[2]), StatsId = statsId, TeamId = teamId });
            await db.SaveChangesAsync();
        }

        public static async Task AddPlayersAsync(StreamReader reader, string teamName)
        {
            var transaction = db.Database.BeginTransaction();
            try
            {
                string? line = await reader.ReadLineAsync();
                if (teamName.Contains("all"))
                {
                    int teamCounter = 0;
                    List<Team> team = await new Read().GetAllTeams();
                    while (line != null)
                    {
                        string[] properties = line.Split(",");
                        line = await reader.ReadLineAsync();
                        CheckProperties(properties);
                        int teamId = team[teamCounter % 23].TeamId;
                        teamCounter++;
                        await CreateDBValues(properties, teamId);
                    }
                }
                else
                {
                    Team team = (await new Read().GetTeamByNameAsync(teamName)).First();
                    while (line != null)
                    {
                        string[] properties = line.Split(",");
                        line = await reader.ReadLineAsync();
                        CheckProperties(properties);
                        await CreateDBValues(properties, team.TeamId);
                    }
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
