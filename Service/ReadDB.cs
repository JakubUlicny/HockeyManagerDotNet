using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    internal static class ReadDB
    {
        private static HockeyManagerDbContext db = new();
        public static List<Team> GetAllTeams()
        {
            return db.Teams.AsNoTracking().ToList();
        }
    }
}
