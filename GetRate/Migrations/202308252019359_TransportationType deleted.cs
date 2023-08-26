namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TransportationTypedeleted : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TransportationTypes", "TransportModeUnitTypeId", "dbo.TransportModeUnitTypes");
            DropForeignKey("dbo.TransportationTypes", "TransportationFromRoutePoint_Id", "dbo.RoutePoints");
            DropForeignKey("dbo.TransportationTypes", "TransportationToRoutePoint_Id", "dbo.RoutePoints");
            DropIndex("dbo.TransportationTypes", new[] { "TransportModeUnitTypeId" });
            DropIndex("dbo.TransportationTypes", new[] { "TransportationFromRoutePoint_Id" });
            DropIndex("dbo.TransportationTypes", new[] { "TransportationToRoutePoint_Id" });
            DropTable("dbo.TransportationTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TransportationTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransportModeUnitTypeId = c.Int(nullable: false),
                        TransportFromRoutePointId = c.Int(),
                        TransportToRoutePointId = c.Int(),
                        TransportationFromRoutePoint_Id = c.Int(),
                        TransportationToRoutePoint_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.TransportationTypes", "TransportationToRoutePoint_Id");
            CreateIndex("dbo.TransportationTypes", "TransportationFromRoutePoint_Id");
            CreateIndex("dbo.TransportationTypes", "TransportModeUnitTypeId");
            AddForeignKey("dbo.TransportationTypes", "TransportationToRoutePoint_Id", "dbo.RoutePoints", "Id");
            AddForeignKey("dbo.TransportationTypes", "TransportationFromRoutePoint_Id", "dbo.RoutePoints", "Id");
            AddForeignKey("dbo.TransportationTypes", "TransportModeUnitTypeId", "dbo.TransportModeUnitTypes", "Id", cascadeDelete: true);
        }
    }
}
