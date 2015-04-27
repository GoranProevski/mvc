using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.BusinessLayer.Contracts
{
    public class BikeDisplayCommand : Command
    {
        public string Action { get; set; }

        public BikeDisplayCommand(string s)
        {
            this.Action = s;
        }
    }
}
