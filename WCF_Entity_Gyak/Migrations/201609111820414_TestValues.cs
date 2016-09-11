namespace WCF_Entity_Gyak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestValues : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DamageTypes", "Name", c => c.String());
            DropColumn("dbo.DamageTypes", "DamageName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DamageTypes", "DamageName", c => c.String());
            DropColumn("dbo.DamageTypes", "Name");
        }
    }
}
