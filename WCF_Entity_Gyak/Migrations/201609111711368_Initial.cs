namespace WCF_Entity_Gyak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        ContractCreationDate = c.DateTime(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Insurances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contract_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contracts", t => t.Contract_Id, cascadeDelete: true)
                .Index(t => t.Contract_Id);
            
            CreateTable(
                "dbo.DamageTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DamageName = c.String(),
                        Value = c.Double(nullable: false),
                        Insurance_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Insurances", t => t.Insurance_Id)
                .Index(t => t.Insurance_Id);
            
            CreateTable(
                "dbo.Lands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Size = c.Double(nullable: false),
                        PricePerSquareMeters = c.Double(nullable: false),
                        Location = c.String(),
                        LocationPriceModifier = c.Double(nullable: false),
                        OwnerName = c.String(),
                        BureauNumber = c.String(),
                        Contract_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contracts", t => t.Contract_Id, cascadeDelete: true)
                .Index(t => t.Contract_Id);
            
            CreateTable(
                "dbo.Grains",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lands", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ICN = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contracts", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Grains", "Id", "dbo.Lands");
            DropForeignKey("dbo.Lands", "Contract_Id", "dbo.Contracts");
            DropForeignKey("dbo.DamageTypes", "Insurance_Id", "dbo.Insurances");
            DropForeignKey("dbo.Insurances", "Contract_Id", "dbo.Contracts");
            DropIndex("dbo.Grains", new[] { "Id" });
            DropIndex("dbo.Lands", new[] { "Contract_Id" });
            DropIndex("dbo.DamageTypes", new[] { "Insurance_Id" });
            DropIndex("dbo.Insurances", new[] { "Contract_Id" });
            DropIndex("dbo.Contracts", new[] { "User_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Grains");
            DropTable("dbo.Lands");
            DropTable("dbo.DamageTypes");
            DropTable("dbo.Insurances");
            DropTable("dbo.Contracts");
        }
    }
}
