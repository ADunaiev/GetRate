namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2508 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransportationTypes", "TransportFromRoutePointId", c => c.Int());
            AddColumn("dbo.TransportationTypes", "TransportToRoutePointId", c => c.Int());
            DropColumn("dbo.TransportationTypes", "FromRoutePointId");
            DropColumn("dbo.TransportationTypes", "ToRoutePointId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TransportationTypes", "ToRoutePointId", c => c.Int());
            AddColumn("dbo.TransportationTypes", "FromRoutePointId", c => c.Int());
            DropColumn("dbo.TransportationTypes", "TransportToRoutePointId");
            DropColumn("dbo.TransportationTypes", "TransportFromRoutePointId");
        }
    }
}
