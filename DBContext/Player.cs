using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeyManager
{
    internal class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public Possition Possition { get; set; }
        public int Age { get; set; }
        public Team Team { get; set; }
        public Stats Stats { get; set; }
    }
}
