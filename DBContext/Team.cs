using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;

//TODO: prerob id z int na Guid
namespace HockeyManager
{
    internal class Team
    {
        [Key] public int TeamId { get; set; }
        public string Name { get; set; }
        public bool Conference { get; set; }
    }
    

}
