using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.DomainModel.Logging
{
    public class SLogger : ILogger
    {

        private static SLogger log = null;

        public void LogIt(string s)
        {
            System.Diagnostics.Debug.WriteLine(s);
        }

        private SLogger()
        {
                
        }

        public static SLogger Logg 
        {
            get 
            {
                if (log == null)
                {
                    log = new SLogger();
                    return log;
                }

                return log;
            }
        }

        public static ILogger GetLogger() 
        {
            return Logg;
        }
    }
}
