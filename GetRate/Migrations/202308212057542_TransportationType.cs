namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TransportationType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TransportationTypes", "FromRoutePointId", c => c.Int());
            AddColumn("dbo.TransportationTypes", "ToRoutePointId", c => c.Int());
            AddColumn("dbo.TransportationTypes", "TransportationFromRoutePoint_Id", c => c.Int());
            AddColumn("dbo.TransportationTypes", "TransportationToRoutePoint_Id", c => c.Int());
            CreateIndex("dbo.TransportationTypes", "TransportationFromRoutePoint_Id");
            CreateIndex("dbo.TransportationTypes", "TransportationToRoutePoint_Id");
            AddForeignKey("dbo.TransportationTypes", "TransportationFromRoutePoint_Id", "dbo.RoutePoints", "Id");
            AddForeignKey("dbo.TransportationTypes", "TransportationToRoutePoint_Id", "dbo.RoutePoints", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransportationTypes", "TransportationToRoutePoint_Id", "dbo.RoutePoints");
            DropForeignKey("dbo.TransportationTypes", "TransportationFromRoutePoint_Id", "dbo.RoutePoints");
            DropIndex("dbo.TransportationTypes", new[] { "TransportationToRoutePoint_Id" });
            DropIndex("dbo.TransportationTypes", new[] { "TransportationFromRoutePoint_Id" });
            DropColumn("dbo.TransportationTypes", "TransportationToRoutePoint_Id");
            DropColumn("dbo.TransportationTypes", "TransportationFromRoutePoint_Id");
            DropColumn("dbo.TransportationTypes", "ToRoutePointId");
            DropColumn("dbo.TransportationTypes", "FromRoutePointId");
        }
    }
}
