using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    internal class SubmitParser
    {
        public async Task<bool> TeamInputParserAsync(string input)
        {
            try
            {
                if (input.SequenceEqual("all"))
                {
                    await new Delete().DeleteTeamAsync(null);
                    return true;
                }
                List<Team> teams = await new Read().GetTeamsByNameAsync(input);
                if (teams == null || teams.Count == 0)
                {
                    throw new KeyNotFoundException(input);
                }
                foreach (Team item in teams)
                {
                    await new Delete().DeleteTeamAsync(item);
                }
                return true;
            }
            catch (InvalidOperationException ex)
            {
                throw;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public async Task<bool> PlayerInputParserAsync(string input)
        {
            try
            {
                if (input.SequenceEqual("all"))
                {
                    await new Delete().DeleteAllPlayersAsync();
                    return true;
                }
                var players = await new Read().GetPlayersByNameAsync(input);
                if (players == null || players.Count == 0)
                {
                    throw new KeyNotFoundException(input);
                }
                foreach (var player in players)
                {
                    await new Delete().DeletePlayerByNameAsync(player);
                }
                return true;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }

}
