using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    internal class Stats
    {
        public int StatsId { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int? CleanSheets { get; set; }
        public int PlusMinus { get; set; }
    }
}