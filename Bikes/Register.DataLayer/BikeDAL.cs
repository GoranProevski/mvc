//using Register.DataLayer.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Register.DomainModel;
using Register.DomainModel.Logging;

namespace Register.DataLayer
{
    public class BikeDAL
    {
        
        private IRegisterContext context;
        private ILogger logger;

        public IEnumerable<Bike> GetBikes() 
        {
            using ((DbContext)context)
            {
                IEnumerable<Bike> bikes = context.Bikes.OrderBy(x => x.Company).ToList();
                logger.LogIt("this is from DL");
                return bikes;
            }
        }

        public BikeDAL(IRegisterContext myContext, ILogger myLogger)
        {
            this.context = myContext;
            this.logger = myLogger;
        }
    }
}
