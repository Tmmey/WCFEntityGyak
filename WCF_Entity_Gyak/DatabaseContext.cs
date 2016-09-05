using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WCF_Entity_Gyak.Model;
using WCF_Entity_Gyak.Model.Configurations;

namespace WCF_Entity_Gyak
{
    public class DataBaseContext :DbContext
    {
        public DataBaseContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataBaseContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new ContractConfig());
            modelBuilder.Configurations.Add(new LandConfig());
            modelBuilder.Configurations.Add(new GrainConfig());
            modelBuilder.Configurations.Add(new InsuranceConfig());

            modelBuilder.Entity<Contract>().HasRequired<User>(t => t.User).WithMany(s => s.Contracts);

            

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Land> Lands { get; set; }
        public DbSet<Grain> Grains { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
    }
}