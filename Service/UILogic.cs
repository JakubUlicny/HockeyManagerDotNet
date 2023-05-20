using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    internal static class UILogic
    {
        public static IOrderedEnumerable<string> FillComboBoxWithTeams()
        {
            return new Read().GetAllTeams().Result.Select(t => t.Name).OrderBy(t => t);
        }

        public static async Task<List<String>> FillComboBoxWithTeams(bool western)
        {
            return (await new Read()
                .GetTeamsByConferenceAsync(western))
                .Select(t => t.Name)
                .OrderBy(t => t)
                .ToList();
        }

        public static Tuple<string, string> MakePlayoffCouples(Dictionary<int, string>  easternTeams, Dictionary<int, string> westernTeams, int index)
        {
            return new Tuple<string, string>(easternTeams[index], westernTeams[index]);
        }
    }
}
