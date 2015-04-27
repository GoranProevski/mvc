using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.DomainModel.Logging
{
    public interface ILogger
    {
        void LogIt(string s);
    }
}
