using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.DomainModel.Logging
{
    public class Logger : ILogger
    {
        public void LogIt(string s)
        {
            System.Diagnostics.Debug.WriteLine(s);
        }
    }
}
