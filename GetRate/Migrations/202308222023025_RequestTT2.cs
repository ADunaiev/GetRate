namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequestTT2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RequestTransportationTypes", "Option", c => c.Int(nullable: false));
            AddColumn("dbo.RequestTransportationTypes", "SubOption", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RequestTransportationTypes", "SubOption");
            DropColumn("dbo.RequestTransportationTypes", "Option");
        }
    }
}
