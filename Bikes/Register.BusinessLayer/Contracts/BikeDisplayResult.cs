//using Register.DataLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Register.DomainModel;

namespace Register.BusinessLayer.Contracts
{
    public class BikeDisplayResult : CommandResult
    {
        public List<Bike> bikes { get; set; }

        public BikeDisplayResult(IEnumerable<Bike> result)
        {
            this.bikes = result.ToList();
        }

        public List<Bike> ReturnResult() 
        {
            return this.bikes;
        }
    }
}
