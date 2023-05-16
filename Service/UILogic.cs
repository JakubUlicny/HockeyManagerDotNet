using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    internal static class UILogic
    {
        public static string[] FillComboBoxWithTeams()
        {
            return new Read().GetAllTeams().Result.Select(t => t.Name).OrderBy(t => t).ToArray();
        }
    }
}
