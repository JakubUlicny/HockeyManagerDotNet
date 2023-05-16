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
                var teams = await new Read().GetTeamsByNameAsync(input);
                if (teams == null || teams.Count == 0)
                {
                    throw new KeyNotFoundException(input);
                }
                foreach (var item in teams)
                {
                    await new Delete().DeleteTeamAsync(item.Name);
                }
                return true;
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
                var players = await new Read().
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
