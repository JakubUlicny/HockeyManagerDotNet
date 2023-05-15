using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;

namespace HockeyManager
{
    internal class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public bool Conference { get; set; }
    }
    

}
