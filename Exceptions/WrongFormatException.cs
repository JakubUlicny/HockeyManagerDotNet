using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager.Exceptions
{
    internal class WrongFormatException : Exception
    {
        WrongFormatException() : base("The file is in wrong format") { }
    }
}
