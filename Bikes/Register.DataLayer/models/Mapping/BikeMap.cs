using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.DataLayer.models.Mapping
{
    public class BikeMap : EntityTypeConfiguration<Register.DomainModel.Bike>
    {

        public BikeMap()
        {
            //Primary Key
            this.HasKey(b => b.BikeId);

            //Properties
            this.Property(b => b.BikeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(b => b.RegNumber)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(b => b.Company)
                .HasMaxLength(30);

            this.Property(b => b.Model)
                .HasMaxLength(20);

            this.Property(b => b.Color)
                .IsRequired()
                .HasMaxLength(15);

            //Table and Column Mappings
            this.ToTable("Bikes");
            this.Property(b => b.BikeId).HasColumnName("BikeId");
            this.Property(b => b.RegNumber).HasColumnName("RegNumber");
            this.Property(b => b.Company).HasColumnName("Company");
            this.Property(b => b.Model).HasColumnName("Model");
            this.Property(b => b.Color).HasColumnName("Color");

        }
    }
}
