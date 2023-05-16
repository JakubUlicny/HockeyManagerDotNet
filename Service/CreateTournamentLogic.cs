using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace HockeyManager
{
    class CreateTournamentLogic
    {

        internal static List<Team> EasternConference { get; set; }
        internal static List<Team> WesternConference { get; set; }

        public static async Task CreateTournamentAsync(int numOfTeams)
        {
            EasternConference = await Task.Factory.StartNew(() => SelectTeam(new Read().GetTeamsByConferenceAsync(true).Result, numOfTeams));
            WesternConference = await Task.Factory.StartNew(()=> SelectTeam(new Read().GetTeamsByConferenceAsync(false).Result, numOfTeams));
            
        } 

        private static List<Team> SelectTeam(List<Team> teams, int numOfTeams) 
        {
            Random random = new Random();
            for (int i = 0; i < numOfTeams; i++)
            {
                var k = random.Next(0, 7);
                var value = teams[k];
                teams[k] = teams[i];
                teams[i] = value;
            }
            return teams.Take(numOfTeams).ToList();
        }
    }
}
