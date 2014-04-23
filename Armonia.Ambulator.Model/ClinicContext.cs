using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Armonia.Ambulator.Model.Nomenclatoare;

namespace Armonia.Ambulator.Model
{
    public class ClinicContext : DbContext
    {
        //public ClinicContext()
        //    : base("Name=ArmoniaAmbulatorContext")
        //{
        //}

        //static ClinicContext()
        //{
        //    Database.SetInitializer<ClinicContext>(null);
        //}

        public DbSet<NomCountry> Countries { get; set; }
        public DbSet<NomCity> Cities { get; set; }
        public DbSet<NomDrug> Drugs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NomCountry>().Property(a => a.Name).HasColumnName("nume_display");
        }
    }
}

