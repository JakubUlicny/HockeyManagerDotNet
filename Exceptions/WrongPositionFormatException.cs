using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    internal class WrongPositionFormatException : Exception
    {
        public WrongPositionFormatException(string position) : base($"There is wrong format of position {position} of your Player") { }
    }
}
