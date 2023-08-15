namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CargoPackage3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Packages", "Payload", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Packages", "GrossWeight");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Packages", "GrossWeight", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Packages", "Payload");
        }
    }
}
