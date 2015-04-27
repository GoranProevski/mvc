//using Register.DataLayer.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using Register.DataLayer.models.Mapping;
using Register.DomainModel;

namespace Register.DataLayer
{
    public class RegisterContext : DbContext, IRegisterContext
    {
        static RegisterContext() 
        {
            Database.SetInitializer<RegisterContext>(null);
        }

        public RegisterContext() : base("Name=RegisterContext")
        {

        }
        public IDbSet<Bike> Bikes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BikeMap());
        }

    }
}
