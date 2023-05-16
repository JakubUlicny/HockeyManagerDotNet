using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    internal class NotMatchingStatsAndPlayersException : Exception
    {
        public NotMatchingStatsAndPlayersException(int deletedPlayers, int deletedStats)
            : base($"We were not able to delete all players and their stats.\n" +
            $"Deleted Players: {deletedPlayers}\n Deleted Stats: {deletedStats}") { }
    }
}
