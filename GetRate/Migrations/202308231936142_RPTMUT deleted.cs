namespace GetRate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RPTMUTdeleted : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RoutePointTransportModeUnitTypes", "RoutePointId", "dbo.RoutePoints");
            DropForeignKey("dbo.RoutePointTransportModeUnitTypes", "TransportModeUnitTypeId", "dbo.TransportModeUnitTypes");
            DropIndex("dbo.RoutePointTransportModeUnitTypes", new[] { "RoutePointId" });
            DropIndex("dbo.RoutePointTransportModeUnitTypes", new[] { "TransportModeUnitTypeId" });
            DropTable("dbo.RoutePointTransportModeUnitTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RoutePointTransportModeUnitTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoutePointId = c.Int(nullable: false),
                        TransportModeUnitTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.RoutePointTransportModeUnitTypes", "TransportModeUnitTypeId");
            CreateIndex("dbo.RoutePointTransportModeUnitTypes", "RoutePointId");
            AddForeignKey("dbo.RoutePointTransportModeUnitTypes", "TransportModeUnitTypeId", "dbo.TransportModeUnitTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RoutePointTransportModeUnitTypes", "RoutePointId", "dbo.RoutePoints", "Id", cascadeDelete: true);
        }
    }
}
