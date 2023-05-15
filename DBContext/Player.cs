using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key] public Guid PlayerId { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public int Age { get; set; }
        public int TeamId { get; set; }
        public int StatsId { get; set; }


    }
}
