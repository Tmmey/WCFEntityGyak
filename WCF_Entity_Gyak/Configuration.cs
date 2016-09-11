using System.Collections.Generic;
using WCF_Entity_Gyak.Model;

namespace WCF_Entity_Gyak.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WCF_Entity_Gyak.DataBaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WCF_Entity_Gyak.DatabaseContext";
        }

        protected override void Seed(WCF_Entity_Gyak.DataBaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            DamageType stormDamageType = new DamageType {Name = "Storm", Value = 100};
            DamageType iceDamageType = new DamageType { Name = "Ice", Value = 200 };
            DamageType fireDamageType = new DamageType { Name = "Fire", Value = 300 };
            
            Insurance basicInsurance = new Insurance {Name = "Basic", DamageType = new List<DamageType> { stormDamageType } };
            Insurance normalInsurance = new Insurance { Name = "Normal", DamageType = new List<DamageType> { stormDamageType, iceDamageType } };
            Insurance fullInsurance = new Insurance { Name = "Full", DamageType = new List<DamageType> {stormDamageType, iceDamageType, fireDamageType} };

            Grain wheatGrain = new Grain {Name = "Wheat", Price = 10};
            Grain ryeGrain = new Grain { Name = "Rye", Price = 20 };

            Land land1 =  new Land
            {
                Size = 500,
                BureauNumber = "TestBuraeauNumber",
                Grain = wheatGrain,
                Location = "TestLocationName",
                LocationPriceModifier = 1.23,
                OwnerName = "TestOwnerName",
                PricePerSquareMeters = 30
            };

            Land land2 = new Land
            {
                Size = 500,
                BureauNumber = "TestBuraeauNumber",
                Grain = ryeGrain,
                Location = "TestLocationName",
                LocationPriceModifier = 1.23,
                OwnerName = "TestOwnerName",
                PricePerSquareMeters = 30
            };

            Contract contract = new Contract
            {
                StartDate = DateTime.Now,
                ContractCreationDate = DateTime.Now,
                Lands = new List<Land> {land1, land2},
                Insurances = new List<Insurance> {fullInsurance}
            };

            User user = new User
            {
                FirstName = "Test",
                LastName = "Test",
                IdentityCardNumber = "TestABC123",
                Contracts = new List<Contract> {contract}
            };

            //context.DamageTypes.AddOrUpdate(
            //    p => p.Name,
            //    stormDamageType,
            //    iceDamageType,
            //    fireDamageType
            //    );

            //context.Insurances.AddOrUpdate(
            //    p => p.Name,
            //    basicInsurance,
            //    normalInsurance,
            //    fullInsurance
            //    );

            //context.Grains.AddOrUpdate(
            //    p => p.Name,
            //    wheatGrain,
            //    ryeGrain
            //    );

            //context.Lands.AddOrUpdate(
            //    p => p.BureauNumber,
            //    land
            //    );

            //context.Contracts.AddOrUpdate(
            //    p => p.Id,
            //    contract
            //    );

            context.Users.AddOrUpdate(
                p => p.IdentityCardNumber,
                user
                );
        }
    }
}
